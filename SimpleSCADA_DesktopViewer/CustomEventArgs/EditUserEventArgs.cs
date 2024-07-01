using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpleSCADA_SharedResources;

namespace SimpleSCADA_DesktopViewer.CustomEventArgs
{
    public class EditUserEventArgs:EventArgs
    {
        public string UserName;
        public User EdittedUser;

        public EditUserEventArgs(string UserName, User EdittedUser)
        {
            this.UserName = UserName;
            this.EdittedUser = EdittedUser;
        }

    }
}
