using System;
using System.IO;
using System.Text;

namespace Recursion
{
    class DirectoryRecursion
    {
        private static readonly StringBuilder s_directoryInfoStr = new StringBuilder();

        static void Main(string[] args)
        {
            GetDirectories(@"E:\练习", 0);
            Console.WriteLine(s_directoryInfoStr.ToString());
            Console.ReadKey();
        }

        /// <summary>
        /// 获取目录
        /// </summary>
        /// <param name="rootPath">根路径</param>
        /// <param name="space">空格缩进数</param>
        public static void GetDirectories(string rootPath, int space)
        {
            string[] directories = Directory.GetDirectories(rootPath);
            foreach (var direct in directories)
            {
                var indentStr = GetIndentStr(space);
                s_directoryInfoStr.AppendLine($"{indentStr}{direct}");
                GetDirectories(direct, space + 2);
            }
        }

        /// <summary>
        /// 获取缩进字符
        /// </summary>
        /// <param name="space">空格数</param>
        /// <returns>缩进字符</returns>
        public static string GetIndentStr(int space)
        {
            StringBuilder spaceStr = new StringBuilder();
            for (int i = 0; i < space; i++)
            {
                spaceStr.Append(" ");
            }

            return spaceStr.ToString();
        }
    }
}
