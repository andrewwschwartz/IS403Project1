using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using IS403Project1.Models;
using IS403Project1.DAL; 

namespace IS403Project1.Controllers
{
    public class MissionController : Controller
    {
        private MissionContext db = new MissionContext();
        // GET: Mission
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult MissionPage(int mission_ID)
        {
            
            
            IEnumerable<MissionQuestions> questions = db.Database.SqlQuery<MissionQuestions>(
                "SELECT MissionQuestions.MissionQuestion_ID, MissionQuestions.question, MissionQuestions.answer, " +
                "MissionQuestions.user_ID, MissionQuestions.mission_ID " +
                "FROM MissionQuestions "+
                "WHERE MissionQuestions.mission_ID = " + mission_ID);
                

            IEnumerable<Missions> missions = db.Database.SqlQuery<Missions>(
                "SELECT Missions.mission_ID, Missions.missionName, Missions.missionPresidentName, Missions.missionAddress, Missions.missionLanguage, " +
                "Missions.missionClimate, Missions.missionDominantReligion, Missions.missionFlag " +
                "FROM Missions " +
                "WHERE Missions.mission_ID = " + mission_ID);

            ViewBag.questions = questions;
            ViewBag.missions = missions;   

            return View(missions);
        }
    }
}