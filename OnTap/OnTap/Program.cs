using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnTap
{
	class Program
	{
		static void Main(string[] args)
		{
			Cay cayMit = new CayMit();
			Cay cayXoai = new CayXoai();

			cayMit.rungLa();
			cayXoai.rungLa();



			TrongCay cayMan = new TrongCay(1, "cay man");
			TrongCay caySauRieng = new TrongCay(2, "cay sau rieng");

			cayMan.showCay();
			caySauRieng.showCay();
			Console.WriteLine("-----------------------------");

			List<TrongCay> listCay = new List<TrongCay>() { new TrongCay(1, "cay vu sua"), new TrongCay(2, "cay xoai") };

			listCay.Add(new TrongCay(3, "cay mit"));
			listCay.Add(new TrongCay(4, "cay tao"));
			listCay.Add(new TrongCay(5, "cay chuoi"));
			listCay.Add(new TrongCay(6, "cay tao 2"));
			listCay.Add(new TrongCay(7, "cay chuoi 2"));
			listCay.Add(new TrongCay(8, "cay mit 2"));

			/*Console.WriteLine("Dung foreach");
			foreach (TrongCay item in listCay) {
				item.showCay();
			}*/

			Console.WriteLine("-----------------------------");
/*			Console.WriteLine("dung for");
			for (int i = 0; i < listCay.Count; i++)
			{
				listCay[i].showCay();
			}*/

			// đổi tên một cây có tên ... trong listCay
			for (int i = 0; i < listCay.Count; i++) {
				if (listCay[i].tenCay == "cay chuoi") {
					listCay[i].tenCay = "cay chuoi 1";
				}
			}

			// xoá một cây có tên ... trong listCay
			for (int i = 0; i < listCay.Count; i++) {
				if (listCay[i].tenCay == "cay tao") {
					listCay.Remove(listCay[i]);
				}
			}

			// Tạo một list cây có chỉ chứa cây mít
			List<TrongCay> listTenCay = new List<TrongCay>(){};
			for (int i = 0; i < listCay.Count; i++) {
				if (listCay[i].tenCay.Contains("cay mit")) {
					listTenCay.Add(listCay[i]);
				}
			}
			void showListMit()
			{
				for (int i = 0; i < listTenCay.Count; i++)
				{
					listTenCay[i].showCay();
				}
			}
			showListMit();

			Console.WriteLine("");
			// đổi tên các cây có chứa tên ...
			for (int i = 0; i < listCay.Count; i++) {
				if (listCay[i].tenCay.Contains("cay")) {
					listCay[i].tenCay = "cai " + listCay[i].tenCay;
				}
			}


			void showList()
			{
				for (int i = 0; i < listCay.Count; i++)
				{
					listCay[i].showCay();
				}
			}
			showList();
		}
	}
}