using System;
using System.Collections.Generic;
using InformationSystem.Models;
using InformationSystem.Constants;

namespace InformationSystem.BusinessContext
{
    public static class InitializeData
    {
        public static readonly User Admin;
        public static readonly IList<Data> DataList;

        static InitializeData()
        {
            Admin = new User
            {
                UserId = 101,
                UserName = AppConstants.Username,
                Password = AppConstants.Password
            };


            DataList = new List<Data>
                {
                new Data
                {
                    LogId=1,
                    Title="World's 15 costliest office markets",
                    Description="The Prime Office Occupancy Costs report is a survey of office occupancy costs for prime office space in 127 cities worldwide. The latest survey provides data on office rents and occupancy costs as of March 31, 2013. The Largest Annual Changes rankings are based upon occupancy costs in local currency and measure.",
                    PublishDate=DateTime.Now.ToShortDateString(),
                    Categary="News",
                    Show=true
                },
                new Data
                { 
                    LogId=2,
                    Title="How to buy used cars",
                    Description="In today's age of having to get things done easy and fast, a car is a necessity. Apart from manufacturer's, the used car market has also grown in the past decade. But buying in the second-hand market is far trickier than choosing a new vehicle.",
                    PublishDate=DateTime.Now.ToShortDateString(),
                    Categary="News",
                    Show=true
                },
                new Data
                { 
                    LogId=3,
                    Title="Dubai's Infinity Tower:",
                    Description="Dubai is now home to the world's tallest twisted building, the Infinity Tower, a AED 1 billion (Rs 1623 Crore) project by UAE-based construction company Arabtec.",
                    PublishDate=DateTime.Now.ToShortDateString(),
                    Categary="News",
                    Show=true
                },
                new Data
                { 
                    LogId=4,
                    Title="The world's 20 best transit airports",
                    Description="The Skytrax World Airport Awards are based on 12 million passenger surveys at 385 different airports, grading the travel experience on 39 criteria. So where is the ideal place to make a connection or a layover? Read on for the 20 best.",
                    PublishDate=DateTime.Now.ToShortDateString(),
                    Categary="News",
                    Show=false
                },
                new Data
                { 
                    LogId=5,
                    Title="7 reasons to dump Facebook",
                    Description="It’s official.  I’m off the Facebook grid.  Nobody offended me.  I didn’t have a bad experience.  While I’m not thrilled about the idea of Big Brother watching my every move, I’m not particularly paranoid about social media sharing.",
                    PublishDate=DateTime.Now.ToShortDateString(),
                    Categary="News",
                    Show=false
                },
                new Data
                { 
                    LogId=6, 
                    Title="Liverpool set to sign Mignolet from Sunderland: Reports",
                    Description="Liverpool have agreed a deal with Sunderland for goalkeeper Simon Mignolet and the Belgium international will sign for the Merseyside club early next week for 9 million pounds, British media reported on Saturday.",
                    PublishDate=DateTime.Now.ToShortDateString(),
                    Categary="Sports",
                    Show=true
                },
                new Data
                { 
                    LogId=7,
                    Title="EPL fixtures: Manchester United face Swansea in season opener",
                    Description="Champions Manchester United will travel to Swansea City for their first Premier League match under new manager David Moyes while Manuel Pellegrini's Manchester City are at home to Newcastle United on August 17.",
                    PublishDate=DateTime.Now.ToShortDateString(),
                    Categary="Sports",
                    Show=false
                },
                new Data
                { 
                    LogId=8,
                    Title="Australia beat Iraq to qualify for 2014 World Cup",
                    Description="Australia left it late but beat Iraq 1-0 to become the second country to qualify for the 2014 World Cup finals in front of 80,000 rain-soaked but euphoric fans at Sydney's Olympic Stadium on Tuesday.",
                    PublishDate=DateTime.Now.ToShortDateString(),
                    Categary="Sports"
                    ,Show=false
                },
                new Data
                { 
                    LogId=9,
                    Title="Nigeria's football team go on strike, miss plane to Brazil",
                    Description="Nigeria's football team went on strike on Thursday, refusing to leave their hotel in Namibia and missing a flight to Brazil where they are supposed to compete in the Confederations Cup, which gets underway at the weekend.",
                    PublishDate=DateTime.Now.ToShortDateString(),
                    Categary="Sports",
                    Show=true
                }
            };
        }
    }
}