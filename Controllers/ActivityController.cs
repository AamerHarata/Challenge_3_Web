﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Challenge_3_Web.Data;
using Microsoft.AspNetCore.Mvc;
using Challenge_3_Web.Models;

namespace Challenge_3_Web.Controllers
{
    public class ActivityController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ActivityController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult DataStream()
        {
//            var allData = _context.RowData.OrderByDescending(x => x.TimeStamp).ThenBy(x => x.GroupNumber).ToList();
            var allData = _context.Windows.OrderByDescending(x => x.TimeStamp).ToList();
            
            
            return View(allData);
        }

        [Route("/GetLatestActivity")]
        public IActionResult LastActivity()
        {
            var activity = "None";
//            var lastActivity = _context.RowData.OrderByDescending(x => x.TimeStamp).Take(1).FirstOrDefault();
            var lastActivity = _context.Windows.OrderByDescending(x => x.TimeStamp).Take(1).FirstOrDefault();

            if (lastActivity == null || lastActivity.Activity.ToString() == "0" || (DateTime.Now - lastActivity.TimeStamp).TotalSeconds > 5)
                return Ok(new {activity = activity});

            activity = lastActivity.Activity.ToString();
            return Ok(new{activity = activity, activityTime= ToDate(lastActivity.TimeStamp), currentTime = ToDate(DateTime.Now), Diff = (DateTime.Now - lastActivity.TimeStamp).Seconds});


//            return lastActivity == null ? Ok(new {activity = "none"}) : Ok(new { activity = lastActivity.Activity.ToString()});
        }

        [Route("/DeleteData/{activity?}")]
        public IActionResult DeleteData(string activity)
        {
//            var result = new List<RowData>();
            var result = new List<Window>();
//            result = string.IsNullOrEmpty(activity) ? _context.RowData.ToList() : _context.RowData.Where(x=>x.Activity.ToString().Equals(activity, StringComparison.CurrentCultureIgnoreCase)).ToList();
            result = string.IsNullOrEmpty(activity) ? _context.Windows.ToList() : _context.Windows.Where(x=>x.Activity.ToString().Equals(activity, StringComparison.CurrentCultureIgnoreCase)).ToList();
            
            
            _context.RemoveRange(result);
            _context.SaveChanges();
            return RedirectToAction(nameof(DataStream));
        }


        [Route("/SaveData/{activity?}")]
        public IActionResult SaveData(string activity)
        {
//            var result = new List<RowData>();
            var result = new List<Window>();
            var fileName = "";
            
            if (string.IsNullOrEmpty(activity)){
//                result = _context.RowData.OrderBy(x=>x.TimeStamp).ToList();
                result = _context.Windows.OrderBy(x=>x.TimeStamp).ToList();
                fileName = "AllData.csv";
            }
            
            
            else
            {
//                result = _context.RowData.Where(x => x.Activity.ToString().Equals(activity, StringComparison.CurrentCultureIgnoreCase)).OrderBy(x=>x.TimeStamp).ToList();
                result = _context.Windows.Where(x => x.Activity.ToString().Equals(activity, StringComparison.CurrentCultureIgnoreCase)).OrderBy(x=>x.TimeStamp).ToList();
                fileName = "DataForActivity_" + activity + ".csv";
            }
            
            
            
            string csv = ListToCSV(result);
            
            
            
            
            
            
            return File(new System.Text.UTF8Encoding().GetBytes(csv), "text/csv", fileName );
        }
        
        
        
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        
//        private string ListToCSV(IEnumerable<RowData> list)
//        {
//            StringBuilder sList = new StringBuilder();
//
////            Type type = typeof(T);
////            var props = type.GetProperties();
//
//            sList.AppendFormat("{0},{1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13},{14},{15},{16},{17},{18}", "#","groupNumber","xAco","yAco","zAco","xGyro","yGyro",
//                "zGyro", "xLino", "yLino", "zLino", "xMag", "yMag", "zMag","AcoSMV", "GyroSMV", "LinAcoSMV", "Pred", "Activity");
//            
////            sList.Append(string.Join(",", props.Select(p => p.Name)));
//            sList.Append(Environment.NewLine);
//
//            var i = 1;
//            foreach (var element in list)
//            {
////                sList.Append(string.Join(",", props.Select(p => p.GetValue(element, null))));
//                sList.AppendFormat("{0},{1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13},{14},{15},{16},{17},{18}", i, element.GroupNumber, element.xAco, element.yAco, element.zAco,
//                    element.xGyro, element.yGyro, element.zGyro, element.xLinAco, element.yLinAco, element.zLinAco, element.xMag, element.yMag, element.zMag, element.AcoSMV, element.GyroSMV, element.LinAcoSMV, element.Pred, element.Activity);
//                sList.Append(Environment.NewLine);
//                i++;
//            }
//
//            return sList.ToString();
//        }

        private string ListToCSV(IEnumerable<Window> list)
        {
            StringBuilder sList = new StringBuilder();

//            Type type = typeof(T);
//            var props = type.GetProperties();

            sList.AppendFormat("{0},{1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13},{14},{15},{16}", "#","MinAco","MaxAco","MeanAco","ModeAco","StdAco"
                ,"MinGyro","MaxGyro","MeanGyro","ModeGyro","StdGyro"
                ,"MinLinAco","MaxLinAco","MeanLinAco","ModeLinAco","StdLinAco"
                ,"Activity");
            
//            sList.Append(string.Join(",", props.Select(p => p.Name)));
            sList.Append(Environment.NewLine);

            var i = 1;
            foreach (var e in list)
            {
//                sList.Append(string.Join(",", props.Select(p => p.GetValue(element, null))));
                sList.AppendFormat("{0},{1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13},{14},{15},{16}", i,e.MinAcoSMV, e.MaxAcoSMV, e.MeanAcoSMV, e.ModeAcoSMV,
                    e.StdAcoSMV,
                    e.MinLinAcoSMV, e.MaxLinAcoSMV, e.MeanLinAcoSMV, e.ModeLinAcoSMV, e.StdLinAcoSMV,
                    e.MinGyroSMV, e.MaxGyroSMV, e.MeanGyroSMV, e.ModeGyroSMV, e.StdGyroSMV,
                    e.Activity);
                sList.Append(Environment.NewLine);
                i++;
            }

            return sList.ToString();
        }

        private string ToDate(DateTime date)
        {
            return date.ToString("hh:mm:ss");
        }
    }
}
