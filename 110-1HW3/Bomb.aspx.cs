using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _110_1HW3
{
    public partial class Bomb : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int[,] ia_Map = new int[10, 10] { {0,0,0,0,0,0,0,0,0,0},
                                              {0,0,0,0,0,0,0,0,0,0},
                                              {0,0,0,0,0,0,0,0,0,0},
                                              {0,0,0,0,0,0,0,0,0,0},
                                              {0,0,0,0,0,0,0,0,0,0},
                                              {0,0,0,0,0,0,0,0,0,0},
                                              {0,0,0,0,0,0,0,0,0,0},
                                              {0,0,0,0,0,0,0,0,0,0},
                                              {0,0,0,0,0,0,0,0,0,0},
                                              {0,0,0,0,0,0,0,0,0,0}};
            int[] ia_MIndex = new int[10] { 0, 7, 13, 28, 44, 62, 74, 75, 87, 90 };

            caBomb(ia_MIndex, ref ia_Map);
            Bombmap(ia_Map);

            Response.Write("<table  style = 'border:2px solid black; width:30%'>");
            for (int i = 0; i <= 9; i++)
            {
                Response.Write("<tr style = 'border:1px solid black'>");
                for (int j = 0; j <= 9; j++)
                {
                    if (ia_Map[i, j] == 0)
                    {
                        Response.Write("<td style = 'border:1px solid black'>&ensp;</td>");
                    }
                    else if (ia_Map[i, j] == -1)
                    {
                        Response.Write("<td style = 'border:1px solid black'>*</td>");
                    }
                    else
                    {
                        Response.Write("<td style = 'border:1px solid black'>" + ia_Map[i, j] + "</td>");
                    }
                }
                Response.Write("</tr>");
            }
            Response.Write("</table>");
        }
        public void caBomb(int[] ia_MIndex, ref int[,] ia_Map)
        {
            for (int i = 0; i < ia_MIndex.Length; i++)
            {
                int ia_x = ia_MIndex[i] / 10;
                int ia_y = ia_MIndex[i] % 10;
                ia_Map[ia_x, ia_y] = -1;
            }
        }
        public void Bombmap(int[,] ia_Map)
        {
            if (ia_Map[0, 0] == -1)
            {
                if (ia_Map[0, 1] != -1) ia_Map[0, 1] += 1;
                if (ia_Map[1, 0] != -1) ia_Map[1, 0] += 1;
                if (ia_Map[1, 1] != -1) ia_Map[1, 1] += 1;
            }
            if (ia_Map[0, 9] == -1)
            {
                if (ia_Map[0, 8] != -1) ia_Map[0, 8] += 1;
                if (ia_Map[1, 9] != -1) ia_Map[1, 9] += 1;
                if (ia_Map[1, 8] != -1) ia_Map[1, 8] += 1;
            }
            if (ia_Map[9, 0] == -1)
            {
                if (ia_Map[8, 0] != -1) ia_Map[8, 0] += 1;
                if (ia_Map[8, 1] != -1) ia_Map[8, 1] += 1;
                if (ia_Map[9, 1] != -1) ia_Map[9, 1] += 1;
            }
            if (ia_Map[9, 9] == -1)
            {
                if (ia_Map[8, 9] != -1) ia_Map[8, 9] += 1;
                if (ia_Map[8, 8] != -1) ia_Map[8, 8] += 1;
                if (ia_Map[9, 8] != -1) ia_Map[9, 8] += 1;
            }
            for (int i = 1; i <= 8; i++)
            {
                if (ia_Map[0, i] == -1)
                {
                    if (ia_Map[0, i - 1] != -1) ia_Map[0, i - 1] += 1;
                    if (ia_Map[0, i + 1] != -1) ia_Map[0, i + 1] += 1;
                    if (ia_Map[1, i - 1] != -1) ia_Map[1, i - 1] += 1;
                    if (ia_Map[1, i] != -1) ia_Map[1, i] += 1;
                    if (ia_Map[1, i + 1] != -1) ia_Map[1, i + 1] += 1;
                }
                if (ia_Map[9, i] == -1)
                {
                    if (ia_Map[9, i - 1] != -1) ia_Map[9, i - 1] += 1;
                    if (ia_Map[9, i + 1] != -1) ia_Map[9, i + 1] += 1;
                    if (ia_Map[8, i - 1] != -1) ia_Map[8, i - 1] += 1;
                    if (ia_Map[8, i] != -1) ia_Map[8, i] += 1;
                    if (ia_Map[8, i + 1] != -1) ia_Map[8, i + 1] += 1;
                }
                if (ia_Map[i, 0] == -1)
                {
                    if (ia_Map[i - 1, 0] != -1) ia_Map[i - 1, 0] += 1;
                    if (ia_Map[i + 1, 0] != -1) ia_Map[i + 1, 0] += 1;
                    if (ia_Map[i - 1, 1] != -1) ia_Map[i - 1, 1] += 1;
                    if (ia_Map[i, 1] != -1) ia_Map[i, 1] += 1;
                    if (ia_Map[i + 1, 1] != -1) ia_Map[i + 1, 1] += 1;
                }
                if (ia_Map[i, 9] == -1)
                {
                    if (ia_Map[i - 1, 9] != -1) ia_Map[i - 1, 9] += 1;
                    if (ia_Map[i + 1, 9] != -1) ia_Map[i + 1, 9] += 1;
                    if (ia_Map[i - 1, 8] != -1) ia_Map[i - 1, 8] += 1;
                    if (ia_Map[i, 8] != -1) ia_Map[i, 8] += 1;
                    if (ia_Map[i + 1, 8] != -1) ia_Map[i + 1, 8] += 1;
                }
            }
            for (int i = 1; i <= 8; i++)
            {
                for (int j = 1; j <= 8; j++)
                {
                    if (ia_Map[i, j] == -1)
                    {
                        if (ia_Map[i - 1, j - 1] != -1) ia_Map[i - 1, j - 1] += 1;
                        if (ia_Map[i - 1, j] != -1) ia_Map[i - 1, j] += 1;
                        if (ia_Map[i - 1, j + 1] != -1) ia_Map[i - 1, j + 1] += 1;
                        if (ia_Map[i, j - 1] != -1) ia_Map[i, j - 1] += 1;
                        if (ia_Map[i, j + 1] != -1) ia_Map[i, j + 1] += 1;
                        if (ia_Map[i + 1, j - 1] != -1) ia_Map[i + 1, j - 1] += 1;
                        if (ia_Map[i + 1, j] != -1) ia_Map[i + 1, j] += 1;
                        if (ia_Map[i + 1, j + 1] != -1) ia_Map[i + 1, j + 1] += 1;
                    }
                }
            }
        }
    }
}