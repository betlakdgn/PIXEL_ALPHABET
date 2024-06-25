using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace PIXEL_ALPHABET
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Yazdırmak istediğiniz kelimeyi giriniz:");
            string kelime = Convert.ToString(Console.ReadLine());
            string buyukharf = kelime.ToUpper();
            char[] chardizi = buyukharf.ToCharArray();
            string[,,] son_yazdırılcak_dizi = new string[9, 0, chardizi.Length];
           
            #region alfabe
           
            string[,,] A =
            {
              { {" XXXXX   "} },
              { {"X     X  "} },
              { {"X     X  "} },
              { {"X     X  "} },
              { {"XXXXXXX  "} },
              { {"X     X  "} },
              { {"X     X  "} },
              { {"X     X  "} },
              { {"X     X  "} }
            };
            string[,,] B =
            {
              { {"XXXXX    "} },
              { {"X    X   "} },
              { {"X     X  "} },
              { {"X    X   "} },
              { {"XXXXX    "} },
              { {"X    X   "} },
              { {"X     X  "} },
              { {"X    X   "} },
              { {"XXXXX    "} }
            };
            string[,,] C =
            {
              { {"XXXXXX   "} },
              { {"X        "} },
              { {"X        "} },
              { {"X        "} },
              { {"X        "} },
              { {"X        "} },
              { {"X        "} },
              { {"X        "} },
              { {"XXXXXX   "} }
            };
            string[,,] D =
            {
              { {"XXXX     "} },
              { {"X   X    "} },
              { {"X    X   "} },
              { {"X     X  "} },
              { {"X     X  "} },
              { {"X     X  "} },
              { {"X    X   "} },
              { {"X   X    "} },
              { {"XXXX     "} }
            };
            string[,,] E =
            {
              { {"XXXXXX   "} },
              { {"X        "} },
              { {"X        "} },
              { {"X        "} },
              { {"XXXXX    "} },
              { {"X        "} },
              { {"X        "} },
              { {"X        "} },
              { {"XXXXXX   "} }
            };
            string[,,] F =
            {
              { {"XXXXXX   "} },
              { {"X        "} },
              { {"X        "} },
              { {"X        "} },
              { {"XXXX     "} },
              { {"X        "} },
              { {"X        "} },
              { {"X        "} },
              { {"X        "} }
            };
            string[,,] G =
            {
              { {"  XXX    "} },
              { {" X       "} },
              { {"X        "} },
              { {"X        "} },
              { {"X  XXX   "} },
              { {"X     X  "} },
              { {"X     X  "} },
              { {" X    X  "} },
              { {"  XXX    "} }
            };
            string[,,] H =
            {
              { {"X     X  "} },
              { {"X     X  "} },
              { {"X     X  "} },
              { {"X     X  "} },
              { {"XXXXXXX  "} },
              { {"X     X  "} },
              { {"X     X  "} },
              { {"X     X  "} },
              { {"X     X  "} }
            };
            string[,,] I =
            {
              { {" XXXXX  "} },
              { {"   X    "} },
              { {"   X    "} },
              { {"   X    "} },
              { {"   X    "} },
              { {"   X    "} },
              { {"   X    "} },
              { {"   X    "} },
              { {" XXXXX  "} }
            };
            string[,,] J =
            {
              { {" XXXXX  "} },
              { {"     X  "} },
              { {"     X "} },
              { {"     X  "} },
              { {"     X  "} },
              { {"     X  "} },
              { {" X   X  "} },
              { {"  X  X  "} },
              { {"    X   "} }
            };
            string[,,] K =
            {
              { {"X    X  "} },
              { {"X   X   "} },
              { {"X  X    "} },
              { {"X X     "} },
              { {"XX      "} },
              { {"X X     "} },
              { {"X  X    "} },
              { {"X   X   "} },
              { {"X    X  "} }
            };
            string[,,] L =
            {
              { {"X        "} },
              { {"X        "} },
              { {"X        "} },
              { {"X        "} },
              { {"X        "} },
              { {"X        "} },
              { {"X        "} },
              { {"X        "} },
              { {"XXXXXXX  "} }
            };
            string[,,] M =
            {
              { {"X       X  "} },
              { {"XX     XX  "} },
              { {"X X   X X  "} },
              { {"X  X X  X  "} },
              { {"X   X   X  "} },
              { {"X       X  "} },
              { {"X       X  "} },
              { {"X       X  "} },
              { {"X       X  "} }
            };
            string[,,] N =
            {
              { {"X      X  "} },
              { {"XX     X  "} },
              { {"X X    X  "} },
              { {"X  X   X  "} },
              { {"X   X  X  "} },
              { {"X    X X  "} },
              { {"X     XX  "} },
              { {"X      X  "} },
              { {"X      X  "} }
            };
            string[,,] O =
            {
              { {" XXXXX   "} },
              { {"X     X  "} },
              { {"X     X  "} },
              { {"X     X  "} },
              { {"X     X  "} },
              { {"X     X  "} },
              { {"X     X  "} },
              { {"X     X  "} },
              { {" XXXXX   "} }
            };
            string[,,] P =
            {
              { {"XXXXX    "} },
              { {"X    X   "} },
              { {"X     X  "} },
              { {"X    X   "} },
              { {"XXXXX    "} },
              { {"X        "} },
              { {"X        "} },
              { {"X        "} },
              { {"X        "} }
            };
            string[,,] R =
            {
              { {"XXXXX    "} },
              { {"X    X   "} },
              { {"X     X  "} },
              { {"X    X   "} },
              { {"XXXX     "} },
              { {"X  X     "} },
              { {"X   X    "} },
              { {"X    X   "} },
              { {"X     X  "} }
            };
            string[,,] S =
            {
              { {"XXXXXX  "} },
              { {"X       "} },
              { {"X       "} },
              { {"X       "} },
              { {"XXXXXX  "} },
              { {"     X  "} },
              { {"     X  "} },
              { {"     X  "} },
              { {"XXXXXX  "} }
            };
            string[,,] T =
            {
              { {"XXXXXXX  "} },
              { {"   X     "} },
              { {"   X     "} },
              { {"   X     "} },
              { {"   X     "} },
              { {"   X     "} },
              { {"   X     "} },
              { {"   X     "} },
              { {"   X     "} }
            };
            string[,,] U =
            {
              { {"X     X  "} },
              { {"X     X  "} },
              { {"X     X  "} },
              { {"X     X  "} },
              { {"X     X  "} },
              { {"X     X  "} },
              { {"X     X  "} },
              { {"X     X  "} },
              { {" XXXXX   "} }
            };
            string[,,] V =
            {
              { {"X     X  "} },
              { {"X     X  "} },
              { {"X     X  "} },
              { {"X     X  "} },
              { {"X     X  "} },
              { {"X     X  "} },
              { {" X   X   "} },
              { {"  X X    "} },
              { {"   X     "} }
            };
            string[,,] W =
            {
              { {"X       X  "} },
              { {"X       X  "} },
              { {"X       X  "} },
              { {"X       X  "} },
              { {"X   X   X  "} },
              { {"X   X   X  "} },
              { {"X  X X  X  "} },
              { {"X X   X X  "} },
              { {" X     X   "} }
            };
            string[,,] Y =
            {
              { {"X     X  "} },
              { {"X     X  "} },
              { {" X   X   "} },
              { {"  X X    "} },
              { {"   X     "} },
              { {"   X     "} },
              { {"   X     "} },
              { {"   X     "} },
              { {"   X     "} }
            };
            string[,,] Z =
            {
              { {"XXXXXXX  "} },
              { {"      X  "} },
              { {"     X   "} },
              { {"    X    "} },
              { {"   X     "} },
              { {"  X      "} },
              { {" X       "} },
              { {"X        "} },
              { {"XXXXXXX  "} }
            };
            #endregion
            for (int i = 0; i < chardizi.Length; i++)
            {
                for (int y = 0; y < 9; y++)//satır sayısı y ile ifade edilsin
                {
                    for (int x = 0; x < chardizi.Length; x++)//dizideki eleman sayısı kadar harf arasın. x ile ifade edilsin.
                    {
                        switch (chardizi[x])
                        {
                            case 'A':
                                Console.Write(A[y, 0, 0]);
                               
                                break;
                            case 'B':
                                Console.Write(B[y, 0, 0]);
                                
                                break;
                            case 'C':
                                Console.Write(C[y, 0, 0]);
                                Thread.Sleep(10);
                                break;
                            case 'D':
                                Console.Write(D[y, 0, 0]);
                                Thread.Sleep(10);
                                break;
                            case 'E':
                                Console.Write(E[y, 0, 0]);
                                Thread.Sleep(10);
                                break;
                            case 'F':
                                Console.Write(F[y, 0, 0]);
                                Thread.Sleep(10);
                                break;
                            case 'G':
                                Console.Write(G[y, 0, 0]);
                                Thread.Sleep(10);
                                break;
                            case 'H':
                                Console.Write(H[y, 0, 0]);
                                Thread.Sleep(10);
                                break;
                            case 'İ':
                                Console.Write(I[y, 0, 0]);
                                Thread.Sleep(10);
                                break;
                            case 'I':
                                Console.Write(I[y, 0, 0]);
                                Thread.Sleep(10);
                                break;
                            case 'J':
                                Console.Write(J[y, 0, 0]);
                                Thread.Sleep(10);
                                break;
                            case 'K':
                                Console.Write(K[y, 0, 0]);
                                Thread.Sleep(10);
                                break;
                            case 'L':
                                Console.Write(L[y, 0, 0]);
                                Thread.Sleep(10);
                                break;
                            case 'M':
                                Console.Write(M[y, 0, 0]);
                                Thread.Sleep(10);
                                break;
                            case 'N':
                                Console.Write(N[y, 0, 0]);
                                Thread.Sleep(10);
                                break;
                            case 'O':
                                Console.Write(O[y, 0, 0]);
                                Thread.Sleep(10);
                                break;
                            case 'P':
                                Console.Write(P[y, 0, 0]);
                                Thread.Sleep(10);
                                break;
                            case 'R':
                                Console.Write(R[y, 0, 0]);
                                Thread.Sleep(10);
                                break;
                            case 'S':
                                Console.Write(S[y, 0, 0]);
                                Thread.Sleep(10);
                                break;
                            case 'T':
                                Console.Write(T[y, 0, 0]);
                                Thread.Sleep(10);
                                break;
                            case 'U':
                                Console.Write(U[y, 0, 0]);
                                Thread.Sleep(10);
                                break;
                            case 'V':
                                Console.Write(V[y, 0, 0]);
                                Thread.Sleep(10);
                                break;
                            case 'W':
                                Console.Write(W[y, 0, 0]);
                                Thread.Sleep(10);
                                break;
                            case 'Y':
                                Console.Write(Y[y, 0, 0]);
                                Thread.Sleep(10);
                                break;
                            case 'Z':
                                Console.Write(Z[y, 0, 0]);
                                Thread.Sleep(10);
                                break;
                        }
                    }
                    Console.WriteLine();
                   
                }
                


            }
           


        }
    }
}
