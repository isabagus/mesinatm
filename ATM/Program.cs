using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
      
        Dictionary<string, (string PIN, decimal Saldo)> pengguna = new Dictionary<string, (string PIN, decimal Saldo)>
        {
            { "user1", ("1234", 500000.00m) },
            { "user2", ("5678", 750000.00m) },
            { "user3", ("4321", 300000.00m) }
        };

       
        Console.WriteLine("Masukkan username:");
        string username = Console.ReadLine();

        if (pengguna.ContainsKey(username))
        {
            Console.WriteLine("Masukkan PIN:");
            string pin = Console.ReadLine();

            if (pengguna[username].PIN == pin)
            {
                Console.WriteLine($"Login berhasil! Saldo Anda: {pengguna[username].Saldo:C}");

                while(true) {
                    Console.WriteLine("=== Menu Atm ===");
                    Console.WriteLine("1. Cek Saldo");
                    Console.WriteLine("2. Riwayat Transaksi");
                    Console.WriteLine("3. Logout ");
                    Console.WriteLine("=== Menu Atm ===");
                    
                    switch (pilihan)
                    {
                        case "1":
                            CekSaldo(saldo);
                            break;
                        case "2":
                            saldo = TarikTunai(saldo, transaksi);
                            break;
                        case "3":
                            saldo = SetorTunai(saldo, transaksi);
                            break;
                        case "4":
                            TampilkanRiwayat(transaksi);
                            break;
                        case "5":
                            pengguna[username] = (pin, saldo); 
                            Console.WriteLine("Logout berhasil. Tekan Enter untuk kembali ke login.");
                            Console.ReadLine();
                            goto Logout; 
                        default:
                            Console.WriteLine("Pilihan tidak valid. Coba lagi.");
                            break;
                    } 

                }
            }
            else
            {
                Console.WriteLine("PIN salah.");
            }
        }
        else
        {
            Console.WriteLine("Username tidak ditemukan.");
        }

       
    }
}
