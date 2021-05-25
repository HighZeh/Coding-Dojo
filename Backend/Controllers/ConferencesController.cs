using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using TestApi.Models;

namespace TestApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ConferencesController : ControllerBase
    {
        private static readonly Conference[] Conferences = new[]
                {
            new Conference {
                guid = "5273ac8b-c5e2-4f7c-af98-b66bb8a2ac41",
                title = "Conference on good stuff",
                abbreviation = "cogs",
                beginning = DateTime.Now,
                ending = (DateTime.Now).AddDays(1),
                lectures = new[]
                    {
                        new Lecture{
                        guid = "04c1d1e7-bc8a-4944-aba3-5feca6b8d414",
                        title = "Kick off talk",
                        lecturer = new Lecturer{
                            guid = "1036c9d9-07e9-43b6-b4d7-9597e4765d10",
                            title = "Prof. Dr.",
                            firstName = "Mac",
                            secondName = "Mastermen",
                            email = "mac.matermen@iot.gov",
                        },
                        beginning = DateTime.Now.AddMinutes(10),
                        ending = DateTime.Now.AddMinutes(40),
                        reviews = new[] {
                            new Review{
                                guid = "a04f2bbd-a96f-4466-a697-e86887cf4207",
                                reviewer = "strenger Max",
                                email = "streng@gmx.de",
                                rating = Rating.red,
                                votingTime = DateTime.Now.AddMinutes(11),
                                comment = "Wenn die Konferenz so weitergeht sehe ich schwarz.",
                            }
                        }
                    },
                }
            },
        };

        [HttpGet]
        public ActionResult<Conference[]> Get()
        {
            return Conferences;
        }
    }
}