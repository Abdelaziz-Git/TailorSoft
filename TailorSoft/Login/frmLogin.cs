using HFS.Global_Classes;
using TailorSoft_Business_Layer;

namespace HFS
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }


        // Evnts
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren())
            {
                MessageBox.Show("من فضلك, صحح الاخطاء أولا قبل تسجيل الدخول.", "خطأ.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();
            if(!clsUser.IsExists(username))
            {
                MessageBox.Show("اسم المستخدم غير موجود.", "خطأ.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string? hashedPassword = clsUser.GetPasswordHash(username);
            if (hashedPassword == null || clsPasswordHelper.VerifyPassword(password, hashedPassword) == false) 
            {
                MessageBox.Show("كلمة المرور غير صحيحة.", "خطأ.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            clsGlobal.CurrentUser = clsUser.Find(username);
            if (clsGlobal.CurrentUser == null)
            {
                MessageBox.Show("حدث خطأ أثناء تسجيل الدخول.", "خطأ.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            this.Hide();
            //using (frmMain mainForm = new frmMain(this))
            //{
            //    mainForm.ShowDialog();
            //}
        }
        private void txtUsername_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtUsername.Text.Trim()))
            {
                errorProvider1.SetError(txtUsername, "Username cannot be empty.");
                e.Cancel = true; // Prevent focus loss
            }
            else
            {
                errorProvider1.SetError(txtUsername, "");
            }
        }
        private void txtPassword_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if(string.IsNullOrEmpty(txtPassword.Text.Trim()))
            {
                errorProvider1.SetError(txtPassword, "Password cannot be empty.");
                e.Cancel = true; // Prevent focus loss
            }
            else
            {
                errorProvider1.SetError(txtPassword, "");
            }
        }
    }
}
