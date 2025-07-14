using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ESM광고Macro.Service
{
    internal class ScheduledWork
    {
        public static async Task RunAtAsync(DateTime targetTime, Control statusOutput, Action action)
        {
            while (true)
            {
                DateTime now = DateTime.Now;
                DateTime scheduledTime = new DateTime(
                    now.Year, now.Month, now.Day,
                    targetTime.Hour, targetTime.Minute, 0
                );

                if (scheduledTime <= now)
                    scheduledTime = scheduledTime.AddDays(1); // 오늘 시간 지났으면 내일로

                TimeSpan delay = scheduledTime - now;
                statusOutput.Text = $"작업 예약됨: {scheduledTime:yyyy-MM-dd HH:mm:ss}";

                await Task.Delay(delay);

                try
                {
                    statusOutput.Text = $"[{DateTime.Now:HH:mm:ss}] 작업 실행됨!";
                    action?.Invoke();
                }
                catch (Exception ex)
                {
                    statusOutput.Text = $"오류 발생: {ex.Message}";
                }

            }
        }
        public static void ConfigureTimeOnly(DateTimePicker picker)
        {
            picker.Format = DateTimePickerFormat.Time;
            picker.ShowUpDown = true;
        }
    }
    
}
