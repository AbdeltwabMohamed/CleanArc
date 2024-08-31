namespace Core.Features.Students.ViewModels
{

    public class StudentListVM
    {
        public StudentListVM(int? id, string name, string addresse, string phone, string Depname)
        {
            StudID = id;
            Name = name;
            Address = addresse;
            Phone = phone;
            DepartmentName1 = Depname;

        }
        public StudentListVM()
        {

        }

        public int? StudID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }

        public string? DepartmentName1 { get; set; }
    }

}
