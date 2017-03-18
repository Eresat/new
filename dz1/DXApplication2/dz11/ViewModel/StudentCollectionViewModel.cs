using DevExpress.Mvvm.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz11.Model
{
    class StudentCollectionViewModel
    {
        public StudentCollectionViewModel()
        {
            GroupList.Add(new Model.Group { Name = "BPI" });
            GroupList.Add(new Model.Group { Name = "BIS" });
            GroupList.Add(new Model.Group { Name = "BIK" });
        }

        [BindableProperty]
        public virtual ObservableCollection<Model.Student> StudentList { get; set; }
        [BindableProperty]
        public virtual ObservableCollection<Model.Student> ExpelledStudentList { get; set; }
        [BindableProperty]
        public virtual ObservableCollection<Model.Group> GroupList { get; set; }

        [BindableProperty]
        public virtual Model.Student CurrentStudent {get;set;}
        [Command]
        public void NewStudent()
        {
            StudentList.Add(new Model.Student());
        }

        [Command]
        public void DeleteStudent(Model.Student stud)
        {
            StudentList.Single(w => w.Id == stud.Id).IsRemoved = true;
        }

        [Command]
        public void EditStudent(Model.Student stud)
        {

        }
        public void StudentOnExpulsion(Model.Student stud)
        {

            ExpelledStudentList.Add(stud);
            StudentList.Remove(stud);
        }
    }
}
