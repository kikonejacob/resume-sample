using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;
using resume.Model;

namespace resume.ViewModel
{
    public class ResumeEditViewModel: INotifyPropertyChanged
    {

        ResumeDb Context = new ResumeDb();


        private Resume _Resume;
        public Resume Resune
        {
            get
            {
                return _Resume;
            }
            set
            {
                _Resume = value;
                NotifyPropertyChanged();
            }
        }


        #region INotifyPropertyChanged Members  
        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        #endregion
    }
}
