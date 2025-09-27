using HFS.Global_Classes;
using Microsoft.Win32;
using TailorSoft;
using TailorSoft_Business_Layer;

namespace TailorSoft
{
    public partial class frmLogin : Form
    {
        private readonly string KeyPath = @"HKEY_CURRENT_USER\Software\TailorSoft\Credentials";
        private string? SavedUsername = string.Empty;
        private string? SavedPasswordHash = string.Empty;
        private bool IsRemember = false;

        readonly string valueName1 = "Username";
        readonly string valueName2 = "Password";
        readonly string valueName3 = "IsRemember";

        public frmLogin()
        {
            ReadCredentialsFromRegistry();
            InitializeComponent();
        }

        private void ReadCredentialsFromRegistry()
        {
            try
            {
                // Normalize subkey path for Registry.CurrentUser (remove the HKEY prefix if present)
                string subKeyPath = KeyPath;
                const string prefix = @"HKEY_CURRENT_USER\";
                if (subKeyPath.StartsWith(prefix, StringComparison.OrdinalIgnoreCase))
                {
                    subKeyPath = subKeyPath.Substring(prefix.Length);
                }

                // Create or open the subkey (CreateSubKey will create it if it doesn't exist)
                using (RegistryKey key = Registry.CurrentUser.CreateSubKey(subKeyPath, writable: true))
                {
                    if (key != null)
                    {
                        // Ensure both values exist — if not, create them with empty string (no data)
                        if (key.GetValue(valueName1) == null)
                            key.SetValue(valueName1, string.Empty, RegistryValueKind.String);

                        if (key.GetValue(valueName2) == null)
                            key.SetValue(valueName2, string.Empty, RegistryValueKind.String);

                        if (key.GetValue(valueName3) == null)
                            key.SetValue(valueName3, "0", RegistryValueKind.String);

                        // Read values (fallback to empty string if null)
                        SavedUsername = key.GetValue(valueName1, string.Empty) as string;
                        SavedPasswordHash = key.GetValue(valueName2, string.Empty) as string;
                        string Value3= key.GetValue(valueName3, "false").ToString() switch 
                        { 
                            "1" => "true", 
                            "0" => "false",
                            _ => throw new FormatException("Invalid boolean string")
                        };
                        if (bool.TryParse(Value3, out IsRemember)) { }
                        else
                            IsRemember = false;

                    }
                    else
                    {
                        // Fallback (shouldn't normally happen)
                        SavedUsername = null;
                        SavedPasswordHash = null;
                        IsRemember = false;
                    }
                }
            }
            catch (Exception ex)
            {
                // Log the error and keep SavedUsername / SavedPasswordHash as null so login fails safely
                MessageBox.Show($"وقع خطأ أثناء الوصول إلى السجل: {ex.Message}");
                SavedUsername = null;
                SavedPasswordHash = null;
            }
        }

        // Events
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren())
            {
                MessageBox.Show("من فضلك, صحح الاخطاء أولا قبل تسجيل الدخول.", "خطأ.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();
            if (SavedUsername is null || SavedUsername.ToLower() != username.ToLower())
            {
                MessageBox.Show("اسم المستخدم غير صحيح.", "خطأ.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (SavedPasswordHash == null || clsPasswordHelper.VerifyPassword(password, SavedPasswordHash) == false)
            {
                MessageBox.Show("كلمة المرور غير صحيحة.", "خطأ.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (frmMain frm = new frmMain())
            {
                this.Hide();
                frm.ShowDialog();
                this.Close();
            }
        }

        private void txtUsername_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtUsername.Text.Trim()))
            {
                errorProvider1.SetError(txtUsername, "اسم المستخدم لا يمكن أن يكون فارغاً.");
            }
            else
            {
                errorProvider1.SetError(txtUsername, "");
            }
        }
        private void txtPassword_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtPassword.Text.Trim()))
            {
                errorProvider1.SetError(txtPassword, "كلمة المرور لا يمكن أن تكون فارغة.");
            }
            else
            {
                errorProvider1.SetError(txtPassword, "");
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            if (IsRemember)
            {
                txtUsername.Text = SavedUsername;
                chkRememberMe.Checked = true;
                if (clsPasswordHelper.VerifyPassword("1234", SavedPasswordHash ?? string.Empty)) 
                {
                    txtPassword.Text = "1234";
                }
                else
                {
                    txtPassword.Text = string.Empty;
                    txtPassword.Focus();
                    return;
                }
                btnLogin.Select();
            }
            else
            {
                txtUsername.Text = string.Empty;
                txtPassword.Text = string.Empty;
                chkRememberMe.Checked = false;
                txtUsername.Select();
            }
        }

        private void frmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void chkRememberMe_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                // Normalize subkey path for Registry.CurrentUser (remove the HKEY prefix if present)
                string subKeyPath = KeyPath;
                const string prefix = @"HKEY_CURRENT_USER\";
                if (subKeyPath.StartsWith(prefix, StringComparison.OrdinalIgnoreCase))
                {
                    subKeyPath = subKeyPath.Substring(prefix.Length);
                }

                // Create or open the subkey (CreateSubKey will create it if it doesn't exist)
                using (RegistryKey key = Registry.CurrentUser.CreateSubKey(subKeyPath, writable: true))
                {
                    if (key != null)
                    {
                        if (key.GetValue(valueName3) == null)
                            key.SetValue(valueName3, "0", RegistryValueKind.String);

                        key?.SetValue(valueName3, chkRememberMe.Checked ? "1" : "0", RegistryValueKind.String);


                    }
                    else
                    {
                        IsRemember = false;
                    }
                }
            }
            catch (Exception ex)
            {
                // Log the error and keep SavedUsername / SavedPasswordHash as null so login fails safely
                MessageBox.Show($"وقع خطأ أثناء الوصول إلى السجل: {ex.Message}");
                IsRemember = false;
            }
        }
    }
}
