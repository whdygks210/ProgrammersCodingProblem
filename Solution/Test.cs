using Solution.Level2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution
{
    public class Test
    {
        public static void Main(string[] args)
        {
            SkillTree skillTree = new SkillTree();

            string skill = "CBD";
            string[] skill_trees = new string[] { "BACDE", "CBADF", "AECB", "BDA" };

            Console.WriteLine(skillTree.solution(skill, skill_trees));
        }
    }
}
