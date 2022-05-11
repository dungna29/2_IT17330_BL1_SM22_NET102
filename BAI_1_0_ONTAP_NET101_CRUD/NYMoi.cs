using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_1_0_ONTAP_NET101_CRUD
{
    //Khi kế thừa lớp cha là Abstract và có phương thức abstract thì lớp con bắt buộc phải ghi đè lại tất cả các phương thức đó nếu không thì không thể trở thành con của lớp abstract.
    internal class NYMoi:Nguoi
    {
        //Phần 1: Khai báo các thuộc tính mà đối tượng cần có
        //Phần 2: Contructor
        //Phần 3: Property
        //Phần 4: Phương thức đối tượng
        //Giai đoạn C#1 sang đến C#2 sử dụng Property
        //------------------------

        //Phần 1: Khai báo các Property mà đối tượng cần có
        // prop + tab
        public double Vong3 { get; set; }

        //Phần 2: Contructor
        public NYMoi()//ctor + tab
        {
            
        }
        //Resharper
        //Tạo contructor có tham số
        //1. Chuột phải vào tên Class Con ở trên -> Quick Actions
        //2. Generate Contructor 'ClassCon(Bên trong có tham số của thuộc tính cha)
        //3. Bôi vào các thuộc tính của con -> Quick Actions -> Add Parameter to contructor -> Chọn cái contructor có tham số vừa Generate ra.
        public NYMoi(int id, string ten, double canNang, int ns, double vong3) : base(id, ten, canNang, ns)
        {
            Vong3 = vong3;
        }
        //Phần 3: Phương thức đối tượng
        //Muốn kế thừa phương thức của lớp cha
        //1. Chuột phải vào tên Class Con ở trên -> Quick Actions
        //2. Generate Overrides sau đó chọn phương thức các bạn muốn kế thừa
        //3. Khi kế thừa lại phương thức của lớp cha thì phương thức đặt tại lớp con có thể code lại nội dung bên trong thì hành động này gọi là ghi đè phương thức.

        //override ghi đè phương thức
        public override void Method1()
        {
            base.Method1();
        }

        public override void InRaManHinh()//Ghi đè lại phương thức abstract của lớp cha
        {
            Console.WriteLine($"{Id} {Ten} {Ns} {CanNang} {Vong3} {(CanNang<=50?"Gầy": CanNang <= 80?"Béo":"Đáng yêu")}");
        }


        //Phân biệt ghi đè và nạp chồng thuộc tính đa hình:
        /*
         * 1. Overloading (Nạp chồng phương thức): Cùng tên nhưng khác tham số.
         * 2. Overriding (Ghi đè phương thức): Phải nhớ đến kế thừa, Phương thức lớp con ghi đè lại phương thức lớp cha và phương phức lớp con phải giống tuyệt đối của cha.
         */
    }
}
