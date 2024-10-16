using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace DreamEase.Models;
public class Note
{
    [PrimaryKey, AutoIncrement]
    public DateTime Date { get; set; } = DateTime.Now;
    public TimeSpan StartTime { get; set; } = DateTime.Now.TimeOfDay;
    public TimeSpan WakeTime { get; set; } = DateTime.Now.TimeOfDay;
    public string StartandWake => $"{StartTime.Hours:D2}:{StartTime.Minutes:D2} TO {WakeTime.Hours:D2}:{WakeTime.Minutes:D2}";
    public int SleepQuality { get; set; }
    
}