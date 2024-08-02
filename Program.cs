namespace June020824
{
    class product
    {        
        public int id { get; set; }
        public String name { get; set; }
        public int qty { get; set; }
        public int rate { get; set; }
    }
    class calculateBill
    {

        //passs array to method as parameter
        public void ShowProducts(product[] pArray)
        {
           

        }
        public void CalBill(product[] pArray)
        {
            int tbill;
            int sumBill = 0;
            Console.WriteLine("***********p ID   name    Qty    rate   Total Bill************");
            for (int i = 0; i < pArray.Length; i++)
            {
                tbill = pArray[i].qty * pArray[i].rate;
                sumBill = sumBill + tbill;
                Console.WriteLine($"{pArray[i].id} {pArray[i].name} {pArray[i].qty} {pArray[i].rate} {tbill}");
            }
            Console.WriteLine("----------------");
            Console.WriteLine("Total Billl =" + sumBill);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {

            //product p=new product();
            //p.id = 333;
            product pp = new product();
            //1
            product[] p1 = new product[3];//
            p1[0] = pp;
            p1[0].id = 1;
            p1[0].name = "Pen";
            p1[0].qty = 10;
            p1[0].rate = 5;

            p1[1] = new product();//1
            p1[1].id = 2;
            p1[1].name = "CD";
            p1[1].qty = 10;
            p1[1].rate = 10;

            p1[2] = new product();//1
            p1[2].id = 3;
            p1[2].name = "DVD";
            p1[2].qty = 10;
            p1[2].rate = 15;

            calculateBill cb1 = new calculateBill();
            cb1.CalBill(p1);

        }
}
}
