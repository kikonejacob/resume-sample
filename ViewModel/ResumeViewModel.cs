using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;
using resume.Model;
using resume.View;
using System.Windows.Input;
using resume.Command;

namespace resume.ViewModel
{
    class ResumeViewModel : INotifyPropertyChanged
    {
        ResumeDb context = new ResumeDb();

        private ICommand _SaveCommand;
        private ICommand _EditCommand;
        private ICommand _NewCommand;
        private bool canExecute =true;
        public ICommand SaveCommand
        {
            get
            {
                return _SaveCommand;
            }
            set
            {
                _SaveCommand = value;
            }
        }
        public ICommand EditCommand
        {
            get
            {
                return _EditCommand;
            }
            set
            {
                _EditCommand = value;
            }
        }
        public ICommand NewCommand
        {
            get
            {
                return _NewCommand;
            }
            set
            {
                _NewCommand = value;
            }
        }

        public ResumeViewModel()
        {
           var q= (from a in context.Resume
                   select a).ToList();
            ResumeList = q;
            SaveCommand = new RelayCommand(SaveResume,param=>this.canExecute);
            EditCommand = new RelayCommand(EditResume, param => this.canExecute);
            NewCommand = new RelayCommand(NewResume, param => this.canExecute);

        }
        private Resume _CurrentResume;
        public Resume CurrentResume
        {
            get
            {
                return _CurrentResume;
            }
            set
            {
                _CurrentResume = value;
                NotifyPropertyChanged();
            }
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

        public void NewResume(object obj)
        {
            CurrentResume = new Resume();
            CurrentResume.ResumeId = 0;
            CurrentResume.PersonalInfo = new PersonalInfo();
            CurrentResume.PersonalInfo.FirstName = "dffddf";
            CurrentResume.WorkHistories = new List<WorkHistory>();
            CurrentResume.Educations = new List<Education>();
            CurrentResume.Certifications = new List<Cert>();
            var a = new EditResume();
            a.DataContext = this;
            a.ShowDialog();
        }
        public void EditResume(object obj)
        {
            if (CurrentResume.ResumeId == 0)
            {

            }
            
        }
        public void SaveResume(object obj)
        {
            if (CurrentResume.ResumeId == 0)
            {
                context.Resume.Add(CurrentResume);
                context.SaveChanges();
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
