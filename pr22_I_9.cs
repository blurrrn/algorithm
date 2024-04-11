using System;
using System.IO;

class Graph
{
    private int[,] adjacencyMatrix; // Матрица смежности для хранения информации о графе
    private int numNodes; // Количество вершин в графе

    public Graph(int[,] matrix)
    {
        adjacencyMatrix = matrix;
        numNodes = matrix.GetLength(0); // Получаем количество вершин в графе из размерности матрицы
    }

    public void PrintIncomingNeighbors(int node)
    {
        Console.WriteLine($"Incoming neighbors of node {node}:");
        for (int i = 0; i < numNodes; i++)
        {
            // Проверяем входящие рёбра для заданной вершины
            if (adjacencyMatrix[i, node] == 1)
            {
                Console.WriteLine($"Node {i}");
            }
        }
    }

    class Node
    {
        public int Value { get; set; }

        public Node(int val)
        {
            Value = val;
        }
    }
}

class Program
{
    static void Main()
    {
        string[] lines = File.ReadAllLines("input.txt"); // Чтение входного файла

        int numNodes = int.Parse(lines[0]); // Получаем количество вершин из первой строки файла
        int[,] adjacencyMatrix = new int[numNodes, numNodes]; // Создаём матрицу смежности

        for (int i = 1; i <= numNodes; i++)
        {
            string[] values = lines[i].Split(' '); // Разбиваем строку на отдельные значения
            for (int j = 0; j < numNodes; j++)
            {
                adjacencyMatrix[i - 1, j] = int.Parse(values[j]); // Заполняем матрицу смежности
            }
        }

        Graph graph = new Graph(adjacencyMatrix); // Создаём граф на основе матрицы смежности

        // Предположим, что нам нужно найти входящие соседи для вершины 1
        graph.PrintIncomingNeighbors(1); // Выводим входящие соседи для выбранной вершины
    }
}
