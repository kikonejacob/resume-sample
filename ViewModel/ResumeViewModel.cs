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
    class ResumeViewModel : INotifyPropertyChanged
    {
        ResumeDb context = new ResumeDb();
       
        public ResumeViewModel()
        {
           var q= (from a in context.Resume
                   select a).ToList();
            ResumeList = q;
        }
        private List<Resume> _ResumeList;
        public List<Resume> ResumeList {
          get
            {
              return _ResumeList;
            }
         set
           {
                _ResumeList = value;
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
