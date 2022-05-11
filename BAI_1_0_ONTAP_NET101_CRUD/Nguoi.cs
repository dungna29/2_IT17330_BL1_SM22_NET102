﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_1_0_ONTAP_NET101_CRUD
{
    //Đã là lớp abstract thì phải có phương thức abstract
    //Nghe đến đến lớp abstract thì nó sẽ là lớp cha
    internal abstract class Nguoi//Lớp cha abstract
    {
        public int Id { get; set; }
        public string Ten { get; set; }
        public double CanNang { get; set; }
        public int Ns { get; set; }

        public Nguoi()
        {
            
        }

        protected Nguoi(int id, string ten, double canNang, int ns)
        {
            Id = id;
            Ten = ten;
            CanNang = canNang;
            Ns = ns;
            //this: Dùng để tham chiếu đến thuộc tính, phương thức của lớp hiện tại
            //base:Dùng để tham chiếu đến thuộc tính, phương thức của lớp cha

        }

        public virtual void Method1()
        {

        }
        //Phương thức abstract: Không body code
        public abstract void InRaManHinh();
    }
}
