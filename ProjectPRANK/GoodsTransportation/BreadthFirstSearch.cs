using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoodsTransportation
{
    class BreadthFirstSearch
    {
        public int n;
        public float[,] a;
        public int end;
        public BreadthFirstSearch(int n, float[,] a/*, int end*/)
        {
            this.n = n;
            this.a = a;
            //this.end = end;
        }        
        public string bfs_search;
        public int[] predecessor;

        public void bfs()
        {
            //draw();
            int rezCheck;
            end = n - 1;
            predecessor = new int[n];
            string temp = "";
            int[,] edges = new int[n, n];
            //Очередь вершин на рассмотрение
            Queue<int> openVertex = new Queue<int>();
            Queue<int> Way = new Queue<int>();
            //Список уже рассмотренных вершин
            List<int> CloseVertex = new List<int>();
            //Начинаем обход с 1й вершины
            openVertex.Enqueue(0);
            //До тех пор, пока не обошли все вершины
            while (openVertex.Count != 0)
            {
                //Выталкиваем из начала списка индекс текущей вершины
                int index = openVertex.Dequeue();
                if (index == end) break;
                //  textBox2.Text += Convert.ToString(index);
                for (short j = 0; j < n; j++)
                {
                    //Если ребро не нулевое 
                    if (a[index, j] != 0)
                    {
                        //И вершина еще не была рассмотрена и не находится в очереди на рассмотрение
                        if (!CloseVertex.Contains(j) && !openVertex.Contains(j))
                        {
                            //Добавить вершину в список на рассмотрение
                            openVertex.Enqueue(j);
                            /////////
                            predecessor[j] = index;
                            /////////
                            edges[index, j] = 1;


                        }
                    }
                    else edges[index, j] = 0;

                }
                //Добавляем информацию о вершине в строку вывода
                //temp += " -> " + Convert.ToString(index + 1);
                //Добавляем вершину в список уже рассмотренных
                CloseVertex.Add(index);
            }

            ////////////////
            rezCheck = end;
            temp += Convert.ToString(end) + " -> ";
            while(true)
            {
                temp = temp.Insert(0, Convert.ToString(predecessor[rezCheck]) + " -> ") /*+= " -> " + Convert.ToString(predecessor[rezCheck])*/;
                rezCheck = predecessor[rezCheck];
                if (rezCheck == 0)
                {
                    temp = temp.Remove(temp.Length - 4);
                    break;
                }
            }
            /////////////////
            bfs_search += "Rezult: ";
            bfs_search += temp;
        }

        //private void draw()
        //{                         // 1,2,3,4,5,6,7,8,9,0,1,2,3,4,5,6,7,8,9
        //    a = new float[n, n] {   {0,1,1,0,0,0,0,0,0,0,1,0,0,0,0,0,0,0,0 },//1
        //                            {1,0,0,1,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },//2
        //                            {1,0,0,0,0,1,1,0,0,0,0,0,0,0,0,0,0,0,0 },//3
        //                            {0,1,0,0,0,0,0,1,1,0,0,0,0,0,0,0,0,0,0 },//4
        //                            {0,1,0,0,0,0,0,0,0,1,0,0,0,0,0,0,0,0,0 },//5
        //                            {0,0,1,0,0,0,0,0,0,0,1,1,0,0,0,0,0,0,0 },//6
        //                            {0,0,1,0,0,0,0,0,0,0,0,0,1,1,0,0,0,0,0 },//7
        //                            {0,0,0,1,0,0,0,0,0,0,0,0,0,0,1,0,0,0,0 },//8
        //                            {0,0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },//9
        //                            {0,0,0,0,1,0,0,0,0,0,0,0,0,0,0,1,0,0,0 },//10
        //                            {0,0,0,0,0,1,0,0,0,0,0,0,0,0,0,0,1,0,0 },//11
        //                            {0,0,0,0,0,1,0,0,0,0,0,0,0,0,0,0,0,1,0 },//12
        //                            {0,0,0,0,0,0,1,0,0,0,0,0,0,0,0,0,0,0,0 },//13
        //                            {0,0,0,0,0,0,1,0,0,0,0,0,0,0,0,0,0,0,1 },//14
        //                            {0,0,0,0,0,0,0,1,0,0,0,0,0,0,0,0,0,0,0 },//15
        //                            {0,0,0,0,0,0,0,0,0,1,0,0,0,0,0,0,0,0,0 },//16
        //                            {0,0,0,0,0,0,0,0,0,0,1,0,0,0,0,0,0,0,0 },//17
        //                            {0,0,0,0,0,0,0,0,0,1,0,1,0,0,0,0,0,0,0 },//18
        //                            {0,0,0,0,0,0,0,0,0,0,0,0,0,1,0,0,0,0,0 }//19
        //                        };


        //}
    }
}
