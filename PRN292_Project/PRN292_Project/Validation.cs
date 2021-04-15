using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRN292_Project.view
{
    class Validation
    {
        public static bool checkFullname(String fullname)
        {
            Regex rgx = new Regex(@"^\s?$");
            if (!rgx.IsMatch(fullname))
            {
                if (fullname.Length < 3 || fullname.Length > 50)
                {
                    MessageBox.Show("Fullname field must between 3 and 50 characters!",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
                return true;
            }
            else
            {
                MessageBox.Show("Fullname field must not empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return false;
        }

        public static bool checkIdentityNo(String identityNo)
        {
            Regex rgx = new Regex(@"^\s?$");
            if (!rgx.IsMatch(identityNo))
            {
                if (!(identityNo.Length == 12))
                {
                    MessageBox.Show("Identity Number must equal 12 numbers",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
                return true;
            }
            else
            {
                MessageBox.Show("Identity Number must not empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return false;
        }

        public static bool checkPhone(String phone)
        {
            Regex rgx = new Regex(@"^(((84)|0)[0-9]{9})$");
            if (rgx.IsMatch(phone))
            {
                return true;
            }
            MessageBox.Show("Phone is not valid!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }
    }
}
