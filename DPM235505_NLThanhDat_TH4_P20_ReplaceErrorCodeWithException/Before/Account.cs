using System;

namespace DPM235505_NLThanhDat_TH4_P20_ReplaceErrorCodeWithException.Before
{
    public class Account
    {
        private int _balance = 1000;

        public int Withdraw(int amount)
        {
            if (amount > _balance)
            {
                // Trả về -1 để báo lỗi, rất dễ bị dev khác bỏ qua và gây lỗi tính toán ngầm
                return -1;
            }
            _balance -= amount;
            return 0; // 0 là thành công
        }
    }
}