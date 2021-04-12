using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChessGameForm
{
    public partial class Form1 : Form
    {
        private Button[,] btn = new Button[8, 8];
        private bool chessPieceSelected = false;
        private Button sourceButton;
        private Button destinationButton;
        private int sourceButtonRow;
        private int sourceButtonColumn;
        private int destinationButtonRow;
        private int destinationButtonColumn;
        public Form1()
        {
            InitializeComponent();
            btn[0, 0] = btn00;
            btn[0, 1] = btn01;
            btn[0, 2] = btn02;
            btn[0, 3] = btn03;
            btn[0, 4] = btn04;
            btn[0, 5] = btn05;
            btn[0, 6] = btn06;
            btn[0, 7] = btn07;

            btn[1, 0] = btn10;
            btn[1, 1] = btn11;
            btn[1, 2] = btn12;
            btn[1, 3] = btn13;
            btn[1, 4] = btn14;
            btn[1, 5] = btn15;
            btn[1, 6] = btn16;
            btn[1, 7] = btn17;

            btn[2, 0] = btn20;
            btn[2, 1] = btn21;
            btn[2, 2] = btn22;
            btn[2, 3] = btn23;
            btn[2, 4] = btn24;
            btn[2, 5] = btn25;
            btn[2, 6] = btn26;
            btn[2, 7] = btn27;

            btn[3, 0] = btn30;
            btn[3, 1] = btn31;
            btn[3, 2] = btn32;
            btn[3, 3] = btn33;
            btn[3, 4] = btn34;
            btn[3, 5] = btn35;
            btn[3, 6] = btn36;
            btn[3, 7] = btn37;

            btn[4, 0] = btn40;
            btn[4, 1] = btn41;
            btn[4, 2] = btn42;
            btn[4, 3] = btn43;
            btn[4, 4] = btn44;
            btn[4, 5] = btn45;
            btn[4, 6] = btn46;
            btn[4, 7] = btn47;

            btn[5, 0] = btn50;
            btn[5, 1] = btn51;
            btn[5, 2] = btn52;
            btn[5, 3] = btn53;
            btn[5, 4] = btn54;
            btn[5, 5] = btn55;
            btn[5, 6] = btn56;
            btn[5, 7] = btn57;

            btn[6, 0] = btn60;
            btn[6, 1] = btn61;
            btn[6, 2] = btn62;
            btn[6, 3] = btn63;
            btn[6, 4] = btn64;
            btn[6, 5] = btn65;
            btn[6, 6] = btn66;
            btn[6, 7] = btn67;

            btn[7, 0] = btn70;
            btn[7, 1] = btn71;
            btn[7, 2] = btn72;
            btn[7, 3] = btn73;
            btn[7, 4] = btn74;
            btn[7, 5] = btn75;
            btn[7, 6] = btn76;
            btn[7, 7] = btn77;

        }
        private void SourceButtonPosition()
        {
            int x = 0;
            while(x<8)
            {
                int y = 0;
                while(y<8)
                {
                    if (sourceButton == btn[x, y])
                    {
                        sourceButtonRow = x;
                        sourceButtonColumn = y;
                    }
                    y++;
                }
                x++;
            }
        }
        private void DestinationButtonPosition()
        {
            int x = 0;
            while (x < 8)
            {
                int y = 0;
                while (y < 8)
                {
                    if (destinationButton == btn[x, y])
                    {
                        destinationButtonRow = x;
                        destinationButtonColumn = y;
                    }
                    y++;
                }
                x++;
            }
        }
        private void MovePiece()
        {
            destinationButton.Image = sourceButton.Image;
            destinationButton.Text = sourceButton.Text;
            sourceButton.Image = null;
            sourceButton.Text = "";
            chessPieceSelected = false;
            if(lblTurn.Text=="White")
            {
                lblTurn.Text = "Black";
            }
            else if(lblTurn.Text == "Black")
            {
                lblTurn.Text = "White";
            }
        }
        private void ValidMoveOfRock()
        {
            if (sourceButtonColumn < destinationButtonColumn)
            {
                int x = sourceButtonColumn + 1;
                while (x < destinationButtonColumn)
                {
                    if (btn[sourceButtonRow, x].Text != "")
                    {
                        chessPieceSelected = false;
                        break;
                    }
                    x++;
                }
            }
            else if (destinationButtonColumn < sourceButtonColumn)
            {
                int x = destinationButtonColumn + 1;
                while (x < sourceButtonColumn)
                {
                    if (btn[sourceButtonRow, x].Text != "")
                    {
                        chessPieceSelected = false;
                        break;
                    }
                    x++;
                }
            }
            else if (destinationButtonRow < sourceButtonRow)
            {
                int x = destinationButtonRow + 1;
                while (x < sourceButtonRow)
                {
                    if (btn[x, sourceButtonColumn].Text != "")
                    {
                        chessPieceSelected = false;
                        break;
                    }
                    x++;
                }
            }
            else if (sourceButtonRow < destinationButtonRow)
            {
                int x = sourceButtonRow + 1;
                while (x < destinationButtonRow)
                {
                    if (btn[x, sourceButtonColumn].Text != "")
                    {
                        chessPieceSelected = false;
                        break;
                    }
                    x++;
                }
            }

            if (chessPieceSelected != false)
            {
                MovePiece();
            }
        }
        private void ValidMoveOfKnight()
        {
            if ((sourceButtonRow > destinationButtonRow) && (sourceButtonColumn < destinationButtonColumn))
            {
                int x = sourceButtonRow - 1;
                int y = sourceButtonColumn + 1;
                while ((x > destinationButtonRow) && (y < destinationButtonColumn))
                {
                    if (btn[x, y].Text != "")
                    {
                        chessPieceSelected = false;
                        break;
                    }
                    x--;
                    y++;
                }
            }
            else if ((sourceButtonRow < destinationButtonRow) && (sourceButtonColumn < destinationButtonColumn))
            {
                int x = sourceButtonRow + 1;
                int y = sourceButtonColumn + 1;
                while ((x < destinationButtonRow) && (y < destinationButtonColumn))
                {
                    if (btn[x, y].Text != "")
                    {
                        chessPieceSelected = false;
                        break;
                    }
                    x++;
                    y++;
                }
            }
            else if ((sourceButtonRow > destinationButtonRow) && (sourceButtonColumn > destinationButtonColumn))
            {
                int x = sourceButtonRow - 1;
                int y = sourceButtonColumn - 1;
                while ((x > destinationButtonRow) && (y > destinationButtonColumn))
                {
                    if (btn[x, y].Text != "")
                    {
                        chessPieceSelected = false;
                        break;
                    }
                    x--;
                    y--;
                }
            }
            else if ((sourceButtonRow < destinationButtonRow) && (sourceButtonColumn > destinationButtonColumn))
            {
                int x = sourceButtonRow + 1;
                int y = sourceButtonColumn - 1;
                while ((x < destinationButtonRow) && (y > destinationButtonColumn))
                {
                    if (btn[x, y].Text != "")
                    {
                        chessPieceSelected = false;
                        break;
                    }
                    x++;
                    y--;
                }
            }

            if (chessPieceSelected != false)
            {
                MovePiece();
            }
        }
        
        private void button_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            int buttonTextLength = button.Text.Length;

            if (chessPieceSelected==false)
            {
                if (button.Text != "")
                {
                    if(lblTurn.Text== "White" && buttonTextLength==1)
                    {
                        sourceButton = button;
                        chessPieceSelected = true;
                    }
                    if (lblTurn.Text == "Black" && buttonTextLength == 2)
                    {
                        sourceButton = button;
                        chessPieceSelected = true;
                    }
                    SourceButtonPosition();
                }
            }
            else
            {
                destinationButton = button;
                DestinationButtonPosition();
                if(sourceButton.Text.Length==destinationButton.Text.Length)
                {
                    chessPieceSelected = false;
                }
                if (lblTurn.Text == "White")
                {
                    if (chessPieceSelected == true)
                    {

                        if (sourceButton.Text == "1")
                        {
                            if (((destinationButtonRow == sourceButtonRow - 1) && (destinationButtonColumn == sourceButtonColumn))||((destinationButtonRow==sourceButtonRow-1)&&(destinationButtonColumn==sourceButtonColumn+1))|| ((destinationButtonRow == sourceButtonRow - 1) && (destinationButtonColumn == sourceButtonColumn - 1)))
                            {
                                if((destinationButton.Text.Length==2) && (destinationButtonColumn==sourceButtonColumn))
                                {
                                    chessPieceSelected = false;
                                }
                                else if((destinationButton.Text=="") && (destinationButtonColumn==sourceButtonColumn))
                                {
                                    MovePiece();
                                    if (destinationButtonRow == 0)
                                    {
                                        destinationButton.Image = Properties.Resources.WhiteQueen;
                                        destinationButton.Text = "5";
                                    }
                                }
                                else if((((destinationButtonRow == sourceButtonRow - 1) && (destinationButtonColumn == sourceButtonColumn + 1)) || ((destinationButtonRow == sourceButtonRow - 1) && (destinationButtonColumn == sourceButtonColumn - 1)))&&(destinationButton.Text.Length == 2))
                                {
                                    if(destinationButton.Text=="16")
                                    {
                                        chessPieceSelected = false;
                                    }
                                    else
                                    {
                                        MovePiece();
                                        if (destinationButtonRow == 0)
                                        {
                                            destinationButton.Image = Properties.Resources.WhiteQueen;
                                            destinationButton.Text = "5";
                                        }
                                    }
                                }
                            }
                        }
                        else if (sourceButton.Text == "2")
                        {
                            if (((destinationButtonRow == sourceButtonRow) && ((destinationButtonColumn == sourceButtonColumn + 1) || (destinationButtonColumn == sourceButtonColumn + 2) || (destinationButtonColumn == sourceButtonColumn + 3) || (destinationButtonColumn == sourceButtonColumn + 4) || (destinationButtonColumn == sourceButtonColumn + 5) || (destinationButtonColumn == sourceButtonColumn + 6) || (destinationButtonColumn == sourceButtonColumn + 7) || (destinationButtonColumn == sourceButtonColumn - 1) || (destinationButtonColumn == sourceButtonColumn - 2) || (destinationButtonColumn == sourceButtonColumn - 3) || (destinationButtonColumn == sourceButtonColumn - 4) || (destinationButtonColumn == sourceButtonColumn - 5) || (destinationButtonColumn == sourceButtonColumn - 6) || (destinationButtonColumn == sourceButtonColumn - 7))) || ((destinationButtonColumn == sourceButtonColumn) && ((destinationButtonRow == sourceButtonRow + 1) || (destinationButtonRow == sourceButtonRow + 2) || (destinationButtonRow == sourceButtonRow + 3) || (destinationButtonRow == sourceButtonRow + 4) || (destinationButtonRow == sourceButtonRow + 5) || (destinationButtonRow == sourceButtonRow + 6) || (destinationButtonRow == sourceButtonRow + 7) || (destinationButtonRow == sourceButtonRow - 1) || (destinationButtonRow == sourceButtonRow - 2) || (destinationButtonRow == sourceButtonRow - 3) || (destinationButtonRow == sourceButtonRow - 4) || (destinationButtonRow == sourceButtonRow - 5) || (destinationButtonRow == sourceButtonRow - 6) || (destinationButtonRow == sourceButtonRow - 7))))
                            {
                                if (destinationButton.Text == "16")
                                {
                                    chessPieceSelected = false;
                                }
                                else
                                {
                                    ValidMoveOfRock();
                                }
                                
                            }
                        }
                        else if (sourceButton.Text == "3")
                        {
                            if (((destinationButtonRow == sourceButtonRow - 1) && (destinationButtonColumn == sourceButtonColumn - 2)) || ((destinationButtonRow == sourceButtonRow - 2) && (destinationButtonColumn == sourceButtonColumn - 1)) || ((destinationButtonRow == sourceButtonRow + 1) && (destinationButtonColumn == sourceButtonColumn - 2)) || ((destinationButtonRow == sourceButtonRow + 2) && (destinationButtonColumn == sourceButtonColumn - 1)) || ((destinationButtonRow == sourceButtonRow - 2) && (destinationButtonColumn == sourceButtonColumn + 1)) || ((destinationButtonRow == sourceButtonRow - 1) && (destinationButtonColumn == sourceButtonColumn + 2)) || ((destinationButtonRow == sourceButtonRow + 2) && (destinationButtonColumn == sourceButtonColumn + 1)) || ((destinationButtonRow == sourceButtonRow + 1) && (destinationButtonColumn == sourceButtonColumn + 2)))
                            {
                                if (destinationButton.Text == "16")
                                {
                                    chessPieceSelected = false;
                                }
                                else
                                {
                                    MovePiece();
                                }
                                
                            }
                        }
                        else if (sourceButton.Text == "4")
                        {
                            if (((destinationButtonRow == sourceButtonRow + 1) && (destinationButtonColumn == sourceButtonColumn + 1)) || ((destinationButtonRow == sourceButtonRow + 2) && (destinationButtonColumn == sourceButtonColumn + 2)) || ((destinationButtonRow == sourceButtonRow + 3) && (destinationButtonColumn == sourceButtonColumn + 3)) || ((destinationButtonRow == sourceButtonRow + 4) && (destinationButtonColumn == sourceButtonColumn + 4)) || ((destinationButtonRow == sourceButtonRow + 5) && (destinationButtonColumn == sourceButtonColumn + 5)) || ((destinationButtonRow == sourceButtonRow + 6) && (destinationButtonColumn == sourceButtonColumn + 6)) || ((destinationButtonRow == sourceButtonRow + 7) && (destinationButtonColumn == sourceButtonColumn + 7)) || ((destinationButtonRow == sourceButtonRow - 1) && (destinationButtonColumn == sourceButtonColumn + 1)) || ((destinationButtonRow == sourceButtonRow - 2) && (destinationButtonColumn == sourceButtonColumn + 2)) || ((destinationButtonRow == sourceButtonRow - 3) && (destinationButtonColumn == sourceButtonColumn + 3)) || ((destinationButtonRow == sourceButtonRow - 4) && (destinationButtonColumn == sourceButtonColumn + 4)) || ((destinationButtonRow == sourceButtonRow - 5) && (destinationButtonColumn == sourceButtonColumn + 5)) || ((destinationButtonRow == sourceButtonRow - 6) && (destinationButtonColumn == sourceButtonColumn + 6)) || ((destinationButtonRow == sourceButtonRow - 7) && (destinationButtonColumn == sourceButtonColumn + 7)) || ((destinationButtonRow == sourceButtonRow + 1) && (destinationButtonColumn == sourceButtonColumn - 1)) || ((destinationButtonRow == sourceButtonRow + 2) && (destinationButtonColumn == sourceButtonColumn - 2)) || ((destinationButtonRow == sourceButtonRow + 3) && (destinationButtonColumn == sourceButtonColumn - 3)) || ((destinationButtonRow == sourceButtonRow + 4) && (destinationButtonColumn == sourceButtonColumn - 4)) || ((destinationButtonRow == sourceButtonRow + 5) && (destinationButtonColumn == sourceButtonColumn - 5)) || ((destinationButtonRow == sourceButtonRow + 6) && (destinationButtonColumn == sourceButtonColumn - 6)) || ((destinationButtonRow == sourceButtonRow + 7) && (destinationButtonColumn == sourceButtonColumn - 7)) || ((destinationButtonRow == sourceButtonRow - 1) && (destinationButtonColumn == sourceButtonColumn - 1)) || ((destinationButtonRow == sourceButtonRow - 2) && (destinationButtonColumn == sourceButtonColumn - 2)) || ((destinationButtonRow == sourceButtonRow - 3) && (destinationButtonColumn == sourceButtonColumn - 3)) || ((destinationButtonRow == sourceButtonRow - 4) && (destinationButtonColumn == sourceButtonColumn - 4)) || ((destinationButtonRow == sourceButtonRow - 5) && (destinationButtonColumn == sourceButtonColumn - 5)) || ((destinationButtonRow == sourceButtonRow - 6) && (destinationButtonColumn == sourceButtonColumn - 6)) || ((destinationButtonRow == sourceButtonRow - 7) && (destinationButtonColumn == sourceButtonColumn - 7)))
                            {
                                if (destinationButton.Text == "16")
                                {
                                    chessPieceSelected = false;
                                }
                                else
                                {
                                    ValidMoveOfKnight();
                                }
                                
                            }
                        }
                        else if (sourceButton.Text == "5")
                        {
                            if (((destinationButtonRow == sourceButtonRow) && ((destinationButtonColumn == sourceButtonColumn + 1) || (destinationButtonColumn == sourceButtonColumn + 2) || (destinationButtonColumn == sourceButtonColumn + 3) || (destinationButtonColumn == sourceButtonColumn + 4) || (destinationButtonColumn == sourceButtonColumn + 5) || (destinationButtonColumn == sourceButtonColumn + 6) || (destinationButtonColumn == sourceButtonColumn + 7) || (destinationButtonColumn == sourceButtonColumn - 1) || (destinationButtonColumn == sourceButtonColumn - 2) || (destinationButtonColumn == sourceButtonColumn - 3) || (destinationButtonColumn == sourceButtonColumn - 4) || (destinationButtonColumn == sourceButtonColumn - 5) || (destinationButtonColumn == sourceButtonColumn - 6) || (destinationButtonColumn == sourceButtonColumn - 7))) || ((destinationButtonColumn == sourceButtonColumn) && ((destinationButtonRow == sourceButtonRow + 1) || (destinationButtonRow == sourceButtonRow + 2) || (destinationButtonRow == sourceButtonRow + 3) || (destinationButtonRow == sourceButtonRow + 4) || (destinationButtonRow == sourceButtonRow + 5) || (destinationButtonRow == sourceButtonRow + 6) || (destinationButtonRow == sourceButtonRow + 7) || (destinationButtonRow == sourceButtonRow - 1) || (destinationButtonRow == sourceButtonRow - 2) || (destinationButtonRow == sourceButtonRow - 3) || (destinationButtonRow == sourceButtonRow - 4) || (destinationButtonRow == sourceButtonRow - 5) || (destinationButtonRow == sourceButtonRow - 6) || (destinationButtonRow == sourceButtonRow - 7))))
                            {
                                if (destinationButton.Text == "16")
                                {
                                    chessPieceSelected = false;
                                }
                                else
                                {
                                    ValidMoveOfRock();
                                }
                                
                            }
                            else if (((destinationButtonRow == sourceButtonRow + 1) && (destinationButtonColumn == sourceButtonColumn + 1)) || ((destinationButtonRow == sourceButtonRow + 2) && (destinationButtonColumn == sourceButtonColumn + 2)) || ((destinationButtonRow == sourceButtonRow + 3) && (destinationButtonColumn == sourceButtonColumn + 3)) || ((destinationButtonRow == sourceButtonRow + 4) && (destinationButtonColumn == sourceButtonColumn + 4)) || ((destinationButtonRow == sourceButtonRow + 5) && (destinationButtonColumn == sourceButtonColumn + 5)) || ((destinationButtonRow == sourceButtonRow + 6) && (destinationButtonColumn == sourceButtonColumn + 6)) || ((destinationButtonRow == sourceButtonRow + 7) && (destinationButtonColumn == sourceButtonColumn + 7)) || ((destinationButtonRow == sourceButtonRow - 1) && (destinationButtonColumn == sourceButtonColumn + 1)) || ((destinationButtonRow == sourceButtonRow - 2) && (destinationButtonColumn == sourceButtonColumn + 2)) || ((destinationButtonRow == sourceButtonRow - 3) && (destinationButtonColumn == sourceButtonColumn + 3)) || ((destinationButtonRow == sourceButtonRow - 4) && (destinationButtonColumn == sourceButtonColumn + 4)) || ((destinationButtonRow == sourceButtonRow - 5) && (destinationButtonColumn == sourceButtonColumn + 5)) || ((destinationButtonRow == sourceButtonRow - 6) && (destinationButtonColumn == sourceButtonColumn + 6)) || ((destinationButtonRow == sourceButtonRow - 7) && (destinationButtonColumn == sourceButtonColumn + 7)) || ((destinationButtonRow == sourceButtonRow + 1) && (destinationButtonColumn == sourceButtonColumn - 1)) || ((destinationButtonRow == sourceButtonRow + 2) && (destinationButtonColumn == sourceButtonColumn - 2)) || ((destinationButtonRow == sourceButtonRow + 3) && (destinationButtonColumn == sourceButtonColumn - 3)) || ((destinationButtonRow == sourceButtonRow + 4) && (destinationButtonColumn == sourceButtonColumn - 4)) || ((destinationButtonRow == sourceButtonRow + 5) && (destinationButtonColumn == sourceButtonColumn - 5)) || ((destinationButtonRow == sourceButtonRow + 6) && (destinationButtonColumn == sourceButtonColumn - 6)) || ((destinationButtonRow == sourceButtonRow + 7) && (destinationButtonColumn == sourceButtonColumn - 7)) || ((destinationButtonRow == sourceButtonRow - 1) && (destinationButtonColumn == sourceButtonColumn - 1)) || ((destinationButtonRow == sourceButtonRow - 2) && (destinationButtonColumn == sourceButtonColumn - 2)) || ((destinationButtonRow == sourceButtonRow - 3) && (destinationButtonColumn == sourceButtonColumn - 3)) || ((destinationButtonRow == sourceButtonRow - 4) && (destinationButtonColumn == sourceButtonColumn - 4)) || ((destinationButtonRow == sourceButtonRow - 5) && (destinationButtonColumn == sourceButtonColumn - 5)) || ((destinationButtonRow == sourceButtonRow - 6) && (destinationButtonColumn == sourceButtonColumn - 6)) || ((destinationButtonRow == sourceButtonRow - 7) && (destinationButtonColumn == sourceButtonColumn - 7)))
                            {
                                if (destinationButton.Text == "16")
                                {
                                    chessPieceSelected = false;
                                }
                                else
                                {
                                    ValidMoveOfKnight();
                                }
                                
                            }
                        }
                        else if (sourceButton.Text == "6")
                        {
                            if (((destinationButtonRow == sourceButtonRow ) && (destinationButtonColumn == sourceButtonColumn - 1))|| ((destinationButtonRow == sourceButtonRow ) && (destinationButtonColumn == sourceButtonColumn +1))|| ((destinationButtonRow == sourceButtonRow + 1) && (destinationButtonColumn == sourceButtonColumn))|| ((destinationButtonRow == sourceButtonRow +1) && (destinationButtonColumn == sourceButtonColumn -1))|| ((destinationButtonRow == sourceButtonRow +1) && (destinationButtonColumn == sourceButtonColumn +1))|| ((destinationButtonRow == sourceButtonRow - 1) && (destinationButtonColumn == sourceButtonColumn))|| ((destinationButtonRow == sourceButtonRow - 1) && (destinationButtonColumn == sourceButtonColumn -1))|| ((destinationButtonRow == sourceButtonRow - 1) && (destinationButtonColumn == sourceButtonColumn +1)))
                            {
                                if (destinationButton.Text == "16")
                                {
                                    chessPieceSelected = false;
                                }
                                else
                                {
                                    MovePiece();
                                }
                                
                            }
                        }
                    }
                }
                else if (lblTurn.Text == "Black")
                {
                    if (chessPieceSelected == true)
                    {
                        if (sourceButton.Text == "11")
                        {
                            if (((destinationButtonRow == sourceButtonRow + 1) && (destinationButtonColumn == sourceButtonColumn)) || ((destinationButtonRow == sourceButtonRow + 1) && (destinationButtonColumn == sourceButtonColumn + 1)) || ((destinationButtonRow == sourceButtonRow + 1) && (destinationButtonColumn == sourceButtonColumn - 1)))
                            {
                                if ((destinationButton.Text.Length == 1) && (destinationButtonColumn == sourceButtonColumn))
                                {
                                    chessPieceSelected = false;
                                }
                                else if ((destinationButton.Text == "") && (destinationButtonColumn == sourceButtonColumn))
                                {
                                    MovePiece();
                                    if (destinationButtonRow == 7)
                                    {
                                        destinationButton.Image = Properties.Resources.BlackQueen;
                                        destinationButton.Text = "15";
                                    }
                                }
                                else if ((((destinationButtonRow == sourceButtonRow + 1) && (destinationButtonColumn == sourceButtonColumn + 1)) || ((destinationButtonRow == sourceButtonRow + 1) && (destinationButtonColumn == sourceButtonColumn - 1))) && (destinationButton.Text.Length == 1))
                                {
                                    if (destinationButton.Text == "6")
                                    {
                                        chessPieceSelected = false;
                                    }
                                    else
                                    {
                                        MovePiece();
                                        if (destinationButtonRow == 7)
                                        {
                                            destinationButton.Image = Properties.Resources.BlackQueen;
                                            destinationButton.Text = "15";
                                        }
                                    }
                                    
                                }
                            }
                        }
                        else if (sourceButton.Text == "12")
                        {
                            if (((destinationButtonRow == sourceButtonRow) && ((destinationButtonColumn == sourceButtonColumn + 1) || (destinationButtonColumn == sourceButtonColumn + 2) || (destinationButtonColumn == sourceButtonColumn + 3) || (destinationButtonColumn == sourceButtonColumn + 4) || (destinationButtonColumn == sourceButtonColumn + 5) || (destinationButtonColumn == sourceButtonColumn + 6) || (destinationButtonColumn == sourceButtonColumn + 7) || (destinationButtonColumn == sourceButtonColumn - 1) || (destinationButtonColumn == sourceButtonColumn - 2) || (destinationButtonColumn == sourceButtonColumn - 3) || (destinationButtonColumn == sourceButtonColumn - 4) || (destinationButtonColumn == sourceButtonColumn - 5) || (destinationButtonColumn == sourceButtonColumn - 6) || (destinationButtonColumn == sourceButtonColumn - 7))) || ((destinationButtonColumn == sourceButtonColumn) && ((destinationButtonRow == sourceButtonRow + 1) || (destinationButtonRow == sourceButtonRow + 2) || (destinationButtonRow == sourceButtonRow + 3) || (destinationButtonRow == sourceButtonRow + 4) || (destinationButtonRow == sourceButtonRow + 5) || (destinationButtonRow == sourceButtonRow + 6) || (destinationButtonRow == sourceButtonRow + 7) || (destinationButtonRow == sourceButtonRow - 1) || (destinationButtonRow == sourceButtonRow - 2) || (destinationButtonRow == sourceButtonRow - 3) || (destinationButtonRow == sourceButtonRow - 4) || (destinationButtonRow == sourceButtonRow - 5) || (destinationButtonRow == sourceButtonRow - 6) || (destinationButtonRow == sourceButtonRow - 7))))
                            {
                                if (destinationButton.Text == "6")
                                {
                                    chessPieceSelected = false;
                                }
                                else
                                {
                                    ValidMoveOfRock();
                                }
                                
                            }
                        }
                        else if (sourceButton.Text == "13")
                        {
                            if (((destinationButtonRow == sourceButtonRow - 1) && (destinationButtonColumn == sourceButtonColumn - 2)) || ((destinationButtonRow == sourceButtonRow - 2) && (destinationButtonColumn == sourceButtonColumn - 1)) || ((destinationButtonRow == sourceButtonRow + 1) && (destinationButtonColumn == sourceButtonColumn - 2)) || ((destinationButtonRow == sourceButtonRow + 2) && (destinationButtonColumn == sourceButtonColumn - 1)) || ((destinationButtonRow == sourceButtonRow - 2) && (destinationButtonColumn == sourceButtonColumn + 1)) || ((destinationButtonRow == sourceButtonRow - 1) && (destinationButtonColumn == sourceButtonColumn + 2)) || ((destinationButtonRow == sourceButtonRow + 2) && (destinationButtonColumn == sourceButtonColumn + 1)) || ((destinationButtonRow == sourceButtonRow + 1) && (destinationButtonColumn == sourceButtonColumn + 2)))
                            {
                                if (destinationButton.Text == "6")
                                {
                                    chessPieceSelected = false;
                                }
                                else
                                {
                                    MovePiece();
                                }
                                
                            }
                        }
                        else if (sourceButton.Text == "14")
                        {
                            if (((destinationButtonRow == sourceButtonRow + 1) && (destinationButtonColumn == sourceButtonColumn + 1)) || ((destinationButtonRow == sourceButtonRow + 2) && (destinationButtonColumn == sourceButtonColumn + 2)) || ((destinationButtonRow == sourceButtonRow + 3) && (destinationButtonColumn == sourceButtonColumn + 3)) || ((destinationButtonRow == sourceButtonRow + 4) && (destinationButtonColumn == sourceButtonColumn + 4)) || ((destinationButtonRow == sourceButtonRow + 5) && (destinationButtonColumn == sourceButtonColumn + 5)) || ((destinationButtonRow == sourceButtonRow + 6) && (destinationButtonColumn == sourceButtonColumn + 6)) || ((destinationButtonRow == sourceButtonRow + 7) && (destinationButtonColumn == sourceButtonColumn + 7)) || ((destinationButtonRow == sourceButtonRow - 1) && (destinationButtonColumn == sourceButtonColumn + 1)) || ((destinationButtonRow == sourceButtonRow - 2) && (destinationButtonColumn == sourceButtonColumn + 2)) || ((destinationButtonRow == sourceButtonRow - 3) && (destinationButtonColumn == sourceButtonColumn + 3)) || ((destinationButtonRow == sourceButtonRow - 4) && (destinationButtonColumn == sourceButtonColumn + 4)) || ((destinationButtonRow == sourceButtonRow - 5) && (destinationButtonColumn == sourceButtonColumn + 5)) || ((destinationButtonRow == sourceButtonRow - 6) && (destinationButtonColumn == sourceButtonColumn + 6)) || ((destinationButtonRow == sourceButtonRow - 7) && (destinationButtonColumn == sourceButtonColumn + 7)) || ((destinationButtonRow == sourceButtonRow + 1) && (destinationButtonColumn == sourceButtonColumn - 1)) || ((destinationButtonRow == sourceButtonRow + 2) && (destinationButtonColumn == sourceButtonColumn - 2)) || ((destinationButtonRow == sourceButtonRow + 3) && (destinationButtonColumn == sourceButtonColumn - 3)) || ((destinationButtonRow == sourceButtonRow + 4) && (destinationButtonColumn == sourceButtonColumn - 4)) || ((destinationButtonRow == sourceButtonRow + 5) && (destinationButtonColumn == sourceButtonColumn - 5)) || ((destinationButtonRow == sourceButtonRow + 6) && (destinationButtonColumn == sourceButtonColumn - 6)) || ((destinationButtonRow == sourceButtonRow + 7) && (destinationButtonColumn == sourceButtonColumn - 7)) || ((destinationButtonRow == sourceButtonRow - 1) && (destinationButtonColumn == sourceButtonColumn - 1)) || ((destinationButtonRow == sourceButtonRow - 2) && (destinationButtonColumn == sourceButtonColumn - 2)) || ((destinationButtonRow == sourceButtonRow - 3) && (destinationButtonColumn == sourceButtonColumn - 3)) || ((destinationButtonRow == sourceButtonRow - 4) && (destinationButtonColumn == sourceButtonColumn - 4)) || ((destinationButtonRow == sourceButtonRow - 5) && (destinationButtonColumn == sourceButtonColumn - 5)) || ((destinationButtonRow == sourceButtonRow - 6) && (destinationButtonColumn == sourceButtonColumn - 6)) || ((destinationButtonRow == sourceButtonRow - 7) && (destinationButtonColumn == sourceButtonColumn - 7)))
                            {
                                if (destinationButton.Text == "6")
                                {
                                    chessPieceSelected = false;
                                }
                                else
                                {
                                    ValidMoveOfKnight();
                                }
                                
                            }
                        }
                        else if (sourceButton.Text == "15")
                        {
                            if (((destinationButtonRow == sourceButtonRow) && ((destinationButtonColumn == sourceButtonColumn + 1) || (destinationButtonColumn == sourceButtonColumn + 2) || (destinationButtonColumn == sourceButtonColumn + 3) || (destinationButtonColumn == sourceButtonColumn + 4) || (destinationButtonColumn == sourceButtonColumn + 5) || (destinationButtonColumn == sourceButtonColumn + 6) || (destinationButtonColumn == sourceButtonColumn + 7) || (destinationButtonColumn == sourceButtonColumn - 1) || (destinationButtonColumn == sourceButtonColumn - 2) || (destinationButtonColumn == sourceButtonColumn - 3) || (destinationButtonColumn == sourceButtonColumn - 4) || (destinationButtonColumn == sourceButtonColumn - 5) || (destinationButtonColumn == sourceButtonColumn - 6) || (destinationButtonColumn == sourceButtonColumn - 7))) || ((destinationButtonColumn == sourceButtonColumn) && ((destinationButtonRow == sourceButtonRow + 1) || (destinationButtonRow == sourceButtonRow + 2) || (destinationButtonRow == sourceButtonRow + 3) || (destinationButtonRow == sourceButtonRow + 4) || (destinationButtonRow == sourceButtonRow + 5) || (destinationButtonRow == sourceButtonRow + 6) || (destinationButtonRow == sourceButtonRow + 7) || (destinationButtonRow == sourceButtonRow - 1) || (destinationButtonRow == sourceButtonRow - 2) || (destinationButtonRow == sourceButtonRow - 3) || (destinationButtonRow == sourceButtonRow - 4) || (destinationButtonRow == sourceButtonRow - 5) || (destinationButtonRow == sourceButtonRow - 6) || (destinationButtonRow == sourceButtonRow - 7))))
                            {
                                if (destinationButton.Text == "6")
                                {
                                    chessPieceSelected = false;
                                }
                                else
                                {
                                    ValidMoveOfRock();
                                }
                                
                            }
                            else if (((destinationButtonRow == sourceButtonRow + 1) && (destinationButtonColumn == sourceButtonColumn + 1)) || ((destinationButtonRow == sourceButtonRow + 2) && (destinationButtonColumn == sourceButtonColumn + 2)) || ((destinationButtonRow == sourceButtonRow + 3) && (destinationButtonColumn == sourceButtonColumn + 3)) || ((destinationButtonRow == sourceButtonRow + 4) && (destinationButtonColumn == sourceButtonColumn + 4)) || ((destinationButtonRow == sourceButtonRow + 5) && (destinationButtonColumn == sourceButtonColumn + 5)) || ((destinationButtonRow == sourceButtonRow + 6) && (destinationButtonColumn == sourceButtonColumn + 6)) || ((destinationButtonRow == sourceButtonRow + 7) && (destinationButtonColumn == sourceButtonColumn + 7)) || ((destinationButtonRow == sourceButtonRow - 1) && (destinationButtonColumn == sourceButtonColumn + 1)) || ((destinationButtonRow == sourceButtonRow - 2) && (destinationButtonColumn == sourceButtonColumn + 2)) || ((destinationButtonRow == sourceButtonRow - 3) && (destinationButtonColumn == sourceButtonColumn + 3)) || ((destinationButtonRow == sourceButtonRow - 4) && (destinationButtonColumn == sourceButtonColumn + 4)) || ((destinationButtonRow == sourceButtonRow - 5) && (destinationButtonColumn == sourceButtonColumn + 5)) || ((destinationButtonRow == sourceButtonRow - 6) && (destinationButtonColumn == sourceButtonColumn + 6)) || ((destinationButtonRow == sourceButtonRow - 7) && (destinationButtonColumn == sourceButtonColumn + 7)) || ((destinationButtonRow == sourceButtonRow + 1) && (destinationButtonColumn == sourceButtonColumn - 1)) || ((destinationButtonRow == sourceButtonRow + 2) && (destinationButtonColumn == sourceButtonColumn - 2)) || ((destinationButtonRow == sourceButtonRow + 3) && (destinationButtonColumn == sourceButtonColumn - 3)) || ((destinationButtonRow == sourceButtonRow + 4) && (destinationButtonColumn == sourceButtonColumn - 4)) || ((destinationButtonRow == sourceButtonRow + 5) && (destinationButtonColumn == sourceButtonColumn - 5)) || ((destinationButtonRow == sourceButtonRow + 6) && (destinationButtonColumn == sourceButtonColumn - 6)) || ((destinationButtonRow == sourceButtonRow + 7) && (destinationButtonColumn == sourceButtonColumn - 7)) || ((destinationButtonRow == sourceButtonRow - 1) && (destinationButtonColumn == sourceButtonColumn - 1)) || ((destinationButtonRow == sourceButtonRow - 2) && (destinationButtonColumn == sourceButtonColumn - 2)) || ((destinationButtonRow == sourceButtonRow - 3) && (destinationButtonColumn == sourceButtonColumn - 3)) || ((destinationButtonRow == sourceButtonRow - 4) && (destinationButtonColumn == sourceButtonColumn - 4)) || ((destinationButtonRow == sourceButtonRow - 5) && (destinationButtonColumn == sourceButtonColumn - 5)) || ((destinationButtonRow == sourceButtonRow - 6) && (destinationButtonColumn == sourceButtonColumn - 6)) || ((destinationButtonRow == sourceButtonRow - 7) && (destinationButtonColumn == sourceButtonColumn - 7)))
                            {
                                if (destinationButton.Text == "6")
                                {
                                    chessPieceSelected = false;
                                }
                                else
                                {
                                    ValidMoveOfKnight();
                                }
                                
                            }
                        }
                        else if (sourceButton.Text == "16")
                        {
                            if (((destinationButtonRow == sourceButtonRow) && (destinationButtonColumn == sourceButtonColumn - 1)) || ((destinationButtonRow == sourceButtonRow) && (destinationButtonColumn == sourceButtonColumn + 1)) || ((destinationButtonRow == sourceButtonRow + 1) && (destinationButtonColumn == sourceButtonColumn)) || ((destinationButtonRow == sourceButtonRow + 1) && (destinationButtonColumn == sourceButtonColumn - 1)) || ((destinationButtonRow == sourceButtonRow + 1) && (destinationButtonColumn == sourceButtonColumn + 1)) || ((destinationButtonRow == sourceButtonRow - 1) && (destinationButtonColumn == sourceButtonColumn)) || ((destinationButtonRow == sourceButtonRow - 1) && (destinationButtonColumn == sourceButtonColumn - 1)) || ((destinationButtonRow == sourceButtonRow - 1) && (destinationButtonColumn == sourceButtonColumn + 1)))
                            {
                                if (destinationButton.Text == "6")
                                {
                                    chessPieceSelected = false;
                                }
                                else
                                {
                                    MovePiece();
                                }
                                
                            }
                        }
                    }
                }
            }
        }

        private void btnSurrender_Click(object sender, EventArgs e)
        {
            if(lblTurn.Text=="Black")
            {
                MessageBox.Show("You Win!!!");
            }
            else if(lblTurn.Text=="White")
            {
                MessageBox.Show("You Lose!!!");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            
        }
    }
}
