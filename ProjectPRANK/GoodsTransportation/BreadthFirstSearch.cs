﻿using System;
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
        public BreadthFirstSearch(int n, float[,] a)
        {
            this.n = n;
            this.a = a;
        }        
        public string bfs_search;

        public void bfs()
        {
            //draw();
            string temp = "";
            int[,] rebra = new int[n, n];
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
                if (index == 5) break;
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
                            rebra[index, j] = 1;


                        }
                    }
                    else rebra[index, j] = 0;

                }
                //Добавляем информацию о вершине в строку вывода
                temp += " -> " + Convert.ToString(index + 1);
                //Добавляем вершину в список уже рассмотренных
                CloseVertex.Add(index);
            }
            bfs_search += "Прохождение графа А в ширину:";
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