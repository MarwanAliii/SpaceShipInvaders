using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;//reads and write data to files or data streams
//Name: Marwan Ali
//Date: Nov 2 - Nov 12 2020
//Program: Swift Salvation
//Purpose: To create a program that runs a game where you dodge projctiled objects and save the world. Also to get a high 90. Additionally to inpress my mom and Mr.Moniaga
namespace SpaceShipInvaders
{
    public partial class swftSalv : Form
    {
        public static int level;//setting the level variable globally so that it can be found in the TicTacToe form
        public static int Round;//setting the Round variable globally so that it can be found in the TicTacToe form

        public swftSalv()
        {
            InitializeComponent();
            //initially setting all picture boxes and labels that are essential during the game playing process. I did this because I wanted everything
            //to be invisible until the user presses the Start button
            picProjectile1.Visible = false;
            picProjectile2.Visible = false;
            picProjectile3.Visible = false;
            picProjectile4.Visible = false;
            picProjectile5.Visible = false;
            picProjectile6.Visible = false;
            picProjectile7.Visible = false;
            picProjectile8.Visible = false;
            picProjectile9.Visible = false;
            picProjectile10.Visible = false;
            picProjectile11.Visible = false;
            picDiagonalProjectile1.Visible = false;
            picDiagonalProjectile2.Visible = false;
            picDiagonalProjectile3.Visible = false;
            lblLevel.Visible = false;
            lblRound.Visible = false;
        }

        //I created this component to ensure that when this form is called in the TicTacToe form, in grasps onto the second component that has the parameters lvl and rond in it
        public swftSalv(int lvl, int rond)
        {
            InitializeComponent();
            //initially setting all picture boxes and labels that are essential during the game playing process.
            picProjectile1.Visible = false;
            picProjectile2.Visible = false;
            picProjectile3.Visible = false;
            picProjectile4.Visible = false;
            picProjectile5.Visible = false;
            picProjectile6.Visible = true;
            picProjectile7.Visible = false;
            picProjectile8.Visible = false;
            picProjectile9.Visible = false;
            picProjectile10.Visible = false;
            picProjectile11.Visible = false;
            picDiagonalProjectile1.Visible = false;
            picDiagonalProjectile2.Visible = false;
            picDiagonalProjectile3.Visible = false;
            lblLevel.Visible = true;
            lblRound.Visible = true;
            //setting the integers level and Round to the parameters lvl and rond so that level and rond will be stored when coming back from TicTacToe
            level = lvl;
            Round = rond;
            btnStart.Enabled = false;//disabling the start button
            btnStart.Visible = false;//making the image inviisble
            lblSwiftSalvation.Visible = false;//making the label inviisble
            tmrProjectileDispatch.Enabled = true;//Enables the timer for the projectled objects when we run it again
            tmrMovePic.Enabled = true;//Enables the timer for the moving space ship when we run it again
            menuStrip.Visible = false;//hiding the menu Strip
        }
        //settings booleans for navigating the Space Ship with the up, down, left, roght buttons on keyboard
        bool goRight, goLeft, goUp, goDown;
        //speed of the space ship
        int dispatch = 12;
        //speed of the projectiles
        int projectileDispatch = 15;
        //Converts of the integers level and Round made for the labels
        string lvlStr, RoundStr;
        //Random number for the labels random colour transistions
        Random rnd = new Random();
        //string that determines which planet section they are in and outputs in the label 
        string planet;
        private void ProjectileDispatch(object sender, EventArgs e)//this is the timer that the whole game lies under
        {
            //Converting level and round to string so that I can place them in a label
            lvlStr = Convert.ToString(level);
            RoundStr = Convert.ToString(Round);
            //Outputting what level the user is on in a level
            lblLevel.Text = "Level: " + lvlStr + " (" + planet + ")";
            lblRound.Text = "Round: " + RoundStr;
            //Game starts at level one, Neptune
            if (level == 1)
            {
                planet = "Neptune";//placing the planet Neptune inside the variable planet
                //assigning all pictureboxes to an iceball comet that lies in an image list i have called listProjectileImages
                picProjectile1.Image = listProjectileImages.Images[1];
                picProjectile2.Image = listProjectileImages.Images[1];
                picProjectile3.Image = listProjectileImages.Images[1];
                picProjectile4.Image = listProjectileImages.Images[1];
                picProjectile5.Image = listProjectileImages.Images[1];
                picProjectile6.Image = listProjectileImages.Images[1];
                picProjectile7.Image = listProjectileImages.Images[1];
                picProjectile8.Image = listProjectileImages.Images[1];
                picProjectile9.Image = listProjectileImages.Images[1];
                picProjectile10.Image = listProjectileImages.Images[1];
                picProjectile11.Image = listProjectileImages.Images[1];

                //First round of level 1
                if (Round == 1)
                {
                    //making sure that the Space Ship doesn't collide with the Projectiles
                    if (picSpaceShip.Bounds.IntersectsWith(picProjectile5.Bounds))//.Bounds.IntersectsWith checks if the image SpaceShip and picProjectile5 collide that I learnt from Code Project (https://www.codeproject.com/Questions/458749/how-do-I-prevent-an-object-from-going-through-anot)
                    {
                        collisionCheck();//a method that I made to run code in the event of a collision
                    }

                    //This is making sure that if the projectile reached the ends of the form, which is 519 units in length, however I found that it visually
                    //appealing to set it to 610 since it transitions faster inbetween Rounds and levels
                    //the image will become invisible and the round will advance
                    if (picProjectile5.Top > 610)//.Top effects the Y.Coordinate of the picture box. I learnt this here -->(https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.control.top?view=net-5.0)
                    {
                        picProjectile5.Visible = false;//making image invisible. I learnt the function .Visible from my prior knowledge in C#
                        Round++;//advancing to next round. accumulation of the variable 
                    }
                    //making projectile visible
                    picProjectile5.Visible = true;
                    //projectile Dispatch
                    picProjectile5.Top += projectileDispatch;
                    //Making other images invisible
                    picProjectile1.Visible = false;
                    picProjectile2.Visible = false;
                    picProjectile3.Visible = false;
                    picProjectile4.Visible = false;
                    picProjectile6.Visible = false;
                    picProjectile7.Visible = false;
                    picProjectile8.Visible = false;
                    picProjectile9.Visible = false;
                    picProjectile10.Visible = false;
                    picProjectile11.Visible = false;
                    picDiagonalProjectile1.Visible = false;
                    picDiagonalProjectile2.Visible = false;
                    picDiagonalProjectile3.Visible = false;
                }

                //checks if the user advanced to Round 2
                else if (Round == 2)
                {
                    //checks if the Space Ship collided with a projectile
                    if (picSpaceShip.Bounds.IntersectsWith(picProjectile3.Bounds) ||
                        picSpaceShip.Bounds.IntersectsWith(picProjectile9.Bounds))
                    {
                        collisionCheck();//a method that I made to run code in the event of a collision
                    }
                    //This is making sure that if the projectile reached the ends of the form
                    if (picProjectile3.Top > 610)
                    {
                        picProjectile3.Visible = false;//making image invisible
                        picProjectile9.Visible = false;//making image invisible
                        Round++;//advancing to next round
                    }

                    //making the images visible after rendering their visibilty
                    picProjectile3.Visible = true;
                    picProjectile9.Visible = true;

                    //projectile Dispatch
                    picProjectile3.Top += projectileDispatch;
                    picProjectile9.Top += projectileDispatch;

                    //Making the other images invisible
                    picProjectile1.Visible = false;
                    picProjectile2.Visible = false;
                    picProjectile4.Visible = false;
                    picProjectile5.Visible = false;
                    picProjectile6.Visible = false;
                    picProjectile7.Visible = false;
                    picProjectile8.Visible = false;
                    picProjectile10.Visible = false;
                    picProjectile11.Visible = false;
                    picDiagonalProjectile1.Visible = false;
                }

                //checks if user advanced to Round 3
                else if (Round == 3)
                {
                    //checks if the Space Ship collided with projectiles
                    if (picSpaceShip.Bounds.IntersectsWith(picProjectile4.Bounds) ||
                        picSpaceShip.Bounds.IntersectsWith(picProjectile8.Bounds) ||
                        picSpaceShip.Bounds.IntersectsWith(picProjectile11.Bounds))
                    {
                        collisionCheck();//a method that I made to run code in the event of a collision
                    }
                    //This is making sure that if the projectile reached the ends of the form
                    if (picProjectile4.Top > 610)
                    {
                        picProjectile4.Visible = false;//making image invisible
                        picProjectile11.Visible = false;//making image invisible
                    }

                    //This is making sure that if the projectile reached the ends of the form
                    if (picProjectile8.Top > 610)
                    {
                        picProjectile8.Visible = false;//making image invisible
                        Round++;//advancing to next round
                        //I add Round++; here because if you read the program a little bit further, you will see the rates
                        //of the prjectiles are different from eachother, indicating that there will be projectiles that reach
                        //the end of the form faster then the rest, so when the slowest of the projectiles reach the end of the form
                        //the round will proceed
                    }
                    //making the images visible after rendering their visibilty
                    picProjectile4.Visible = true;
                    picProjectile8.Visible = true;
                    picProjectile11.Visible = true;
                    //projectile dispatch
                    picProjectile4.Top += projectileDispatch;
                    picProjectile8.Top += projectileDispatch;
                    picProjectile11.Top += projectileDispatch;
                    //Making the other images invisible
                    picProjectile1.Visible = false;
                    picProjectile2.Visible = false;
                    picProjectile3.Visible = false;
                    picProjectile5.Visible = false;
                    picProjectile6.Visible = false;
                    picProjectile7.Visible = false;
                    picProjectile9.Visible = false;
                    picProjectile10.Visible = false;
                    picDiagonalProjectile1.Visible = false;
                }
                //checks if the user advanced to Round 4
                else if (Round == 4)
                {
                    //checks if the Space Ship collied with a projectile
                    if (picSpaceShip.Bounds.IntersectsWith(picProjectile1.Bounds) ||
                        picSpaceShip.Bounds.IntersectsWith(picProjectile2.Bounds) ||
                        picSpaceShip.Bounds.IntersectsWith(picProjectile6.Bounds) ||
                        picSpaceShip.Bounds.IntersectsWith(picProjectile7.Bounds))
                    {
                        collisionCheck();//a method that I made to run code in the event of a collision
                    }
                    //This is making sure that if the projectile reached the ends of the form
                    if (picProjectile7.Top > 610)
                    {
                        picProjectile7.Visible = false;//making image invisible
                    }
                    //This is making sure that if the projectile reached the ends of the form
                    if (picProjectile2.Top > 610)
                    {
                        picProjectile2.Visible = false;//making image invisible
                    }
                    //This is making sure that if the projectile reached the ends of the form
                    if (picProjectile1.Top > 610)
                    {
                        picProjectile1.Visible = false;//making the image invisible
                    }
                    //This is making sure that if the projectile reached the ends of the form
                    if (picProjectile6.Top > 610)
                    {
                        picProjectile6.Visible = false;//making the image invisbile
                        picDiagonalProjectile1.Visible = true;//making an image visible after projectile 6 reached the end of the form
                        picDiagonalProjectile1.Top += projectileDispatch;//dispatching an image after projectile 6 reached the end of the form
                        picDiagonalProjectile1.Left -= projectileDispatch + 1;//.Left will play around with the comets x coordinates
                                                                              //making the comet move diagonally I learnt this here -->(https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.control.top?view=net-5.0)
                        if (picSpaceShip.Bounds.IntersectsWith(picDiagonalProjectile1.Bounds)) collisionCheck();//checks if space ship hits comet
                        //I placed this code here because I want the user to lose once they hit the comet when its visible and moving
                    }
                    //This is making sure that if the projectile reached the ends of the form
                    if (picDiagonalProjectile1.Top > 610 || picDiagonalProjectile1.Left < 0)
                    {
                        picDiagonalProjectile1.Visible = false;//making image invisible
                        //moving the pictureboxes to their initial location before starting the next level
                        picProjectile1.Location = new Point(1, 3);//.Location changes the location of an image and the numbers in the brackets are the coordinates. I learnt this here --> (https://stackoverflow.com/questions/15112783/change-the-position-of-an-picturebox)
                        picProjectile2.Location = new Point(74, 3);
                        picProjectile3.Location = new Point(147, 3);
                        picProjectile4.Location = new Point(220, 3);
                        picProjectile5.Location = new Point(293, 3);
                        picProjectile6.Location = new Point(363, 3);
                        picProjectile7.Location = new Point(436, 3);
                        picProjectile8.Location = new Point(509, 3);
                        picProjectile9.Location = new Point(582, 3);
                        picProjectile10.Location = new Point(655, 3);
                        picProjectile11.Location = new Point(728, 3);
                        level++;//Proceeding to next Level!!
                        Round = 1;//Refreshing the rounds, because after advancing to the next level, the user will start Round one of that level
                    }

                    //making the images visible after rendering their visibilty
                    picProjectile1.Visible = true;
                    picProjectile2.Visible = true;
                    picProjectile6.Visible = true;
                    picProjectile7.Visible = true;
                    //projectile Dispatch
                    picProjectile1.Top += projectileDispatch + 1;
                    picProjectile2.Top += projectileDispatch + 2;
                    picProjectile6.Top += projectileDispatch;
                    picProjectile7.Top += projectileDispatch + 3;
                    //Making the other images invisible
                    picProjectile3.Visible = false;
                    picProjectile4.Visible = false;
                    picProjectile5.Visible = false;
                    picProjectile8.Visible = false;
                    picProjectile9.Visible = false;
                    picProjectile10.Visible = false;
                    picProjectile11.Visible = false;
                }
            }

            //ckecking if the reached to level 2, Uranus
            else if (level == 2)
            {
                planet = "Uranus";//placing the planet Uranus inside the variable planet
                //Changing the images in the pictureboxes as they proceed to level 2
                picProjectile1.Image = listProjectileImages.Images[1];
                picProjectile2.Image = listProjectileImages.Images[1];
                picProjectile3.Image = listProjectileImages.Images[3];
                picProjectile4.Image = listProjectileImages.Images[1];
                picProjectile5.Image = listProjectileImages.Images[3];
                picProjectile6.Image = listProjectileImages.Images[3];
                picProjectile7.Image = listProjectileImages.Images[1];
                picProjectile8.Image = listProjectileImages.Images[3];
                picProjectile9.Image = listProjectileImages.Images[3];
                picProjectile10.Image = listProjectileImages.Images[3];
                picProjectile11.Image = listProjectileImages.Images[1];

                //checking if the user advanced to Round 1 level 2
                if (Round == 1)
                {
                    //checking if the SpaceShip collided with any of the projectiled objects
                    if (picSpaceShip.Bounds.IntersectsWith(picProjectile1.Bounds) ||
                        picSpaceShip.Bounds.IntersectsWith(picProjectile4.Bounds) ||
                        picSpaceShip.Bounds.IntersectsWith(picProjectile9.Bounds))
                    {
                        collisionCheck();//a method that I made to run code in the event of a collision
                    }

                    //This is making sure that if the projectile reached the ends of the form
                    if (picProjectile4.Top > 610)
                    {
                        picProjectile4.Visible = false;//making image invisible
                    }
                    //This is making sure that if the projectile reached the ends of the form
                    if (picProjectile1.Top > 610)
                    {
                        picProjectile1.Visible = false;//making image invisible
                        picProjectile9.Visible = false;//making image invisible
                        Round++;//proceed to the next round
                    }

                    //making the images visible after rendering their visibilty
                    picProjectile1.Visible = true;
                    picProjectile4.Visible = true;
                    picProjectile9.Visible = true;
                    //projectile Dispatch
                    picProjectile1.Top += projectileDispatch;
                    picProjectile4.Top += projectileDispatch + 1;
                    picProjectile9.Top += projectileDispatch;
                    //Making the other images invisible
                    picProjectile2.Visible = false;
                    picProjectile3.Visible = false;
                    picProjectile5.Visible = false;
                    picProjectile6.Visible = false;
                    picProjectile7.Visible = false;
                    picProjectile8.Visible = false;
                    picProjectile10.Visible = false;
                    picProjectile11.Visible = false;
                }

                //checking if the user advanced to Round 2
                else if(Round == 2)
                {
                    //checking if the SpaceShip collided with any of the projectiled objects
                    if (picSpaceShip.Bounds.IntersectsWith(picProjectile2.Bounds) ||
                        picSpaceShip.Bounds.IntersectsWith(picProjectile6.Bounds) ||
                        picSpaceShip.Bounds.IntersectsWith(picProjectile10.Bounds))
                    {
                        collisionCheck();//a method that I made to run code in the event of a collision
                    }

                    //This is making sure that if the projectile reached the ends of the form
                    if (picProjectile10.Top > 610)
                    {
                        picProjectile10.Visible = false;//making image invisible
                    }
                    //This is making sure that if the projectile reached the ends of the form
                    if (picProjectile2.Top > 610)
                    {
                        picProjectile2.Visible = false;//making image invisible
                    }
                    //This is making sure that if the projectile reached the ends of the form
                    if (picProjectile6.Top > 610)
                    {
                        picProjectile6.Visible = false;//making image invisible
                        Round++;//advancing to next round
                    }

                    //making the images visible after rendering their visibilty
                    picProjectile10.Visible = true;
                    picProjectile2.Visible = true;
                    picProjectile6.Visible = true;
                    //projectile Dispatch
                    picProjectile2.Top += projectileDispatch + 2;
                    picProjectile6.Top += projectileDispatch + 1;
                    picProjectile10.Top += projectileDispatch + 3;
                    //Making the other images invisible
                    picProjectile1.Visible = false;
                    picProjectile3.Visible = false;
                    picProjectile4.Visible = false;
                    picProjectile5.Visible = false;
                    picProjectile7.Visible = false;
                    picProjectile8.Visible = false;
                    picProjectile9.Visible = false;
                    picProjectile11.Visible = false;
                }

                //checking if the user advanced to Round 3
                else if (Round == 3)
                {
                    //checking if the SpaceShip collided with any of the projectiled objects
                    if (picSpaceShip.Bounds.IntersectsWith(picProjectile11.Bounds))
                    {
                        collisionCheck();//a method that I made to run code in the event of a collision
                    }
                    //This is making sure that if the projectile reached the ends of the form
                    if (picProjectile11.Top > 610)
                    {
                        picProjectile11.Visible = false;//making image invisible
                        picProjectile3.Visible = true;//making image visible after projectile 11 reaches the end of the form
                        picProjectile3.Top += projectileDispatch + 10;//projectile Dispatch

                        //checking if the SpaceShip collided with any of the projectiled object after being launched
                        if (picSpaceShip.Bounds.IntersectsWith(picProjectile3.Bounds)) collisionCheck();
                    }
                    //This is making sure that if the projectile reached the ends of the form
                    if (picProjectile3.Top > 610)
                    {
                        picProjectile3.Visible = false;//making image invisible
                        Round++;//advancing to next round
                    }

                    //making the images visible after rendering their visibilty
                    picProjectile11.Visible = true;
                    //projectile Dispatch
                    picProjectile11.Top += projectileDispatch + 2;
                    //Making the other images invisible
                    picProjectile1.Visible = false;
                    picProjectile2.Visible = false;
                    picProjectile4.Visible = false;
                    picProjectile5.Visible = false;
                    picProjectile6.Visible = false;
                    picProjectile7.Visible = false;
                    picProjectile8.Visible = false;
                    picProjectile9.Visible = false;
                    picProjectile10.Visible = false;
                }

                //checking of the user advanced to Round 4
                else if (Round == 4)
                {
                    //checking if the SpaceShip collided with any of the projectiled objects
                    if (picSpaceShip.Bounds.IntersectsWith(picProjectile8.Bounds))
                    {
                        collisionCheck();//a method that I made to run code in the event of a collision
                    }
                    //This is making sure that if the projectile reached the ends of the form
                    if (picProjectile8.Top > 610)
                    {
                        picProjectile8.Visible = false;//making image invisible
                        picProjectile5.Visible = true;//making image visible after projectile 8 reaches end of the form
                        picProjectile5.Top += projectileDispatch + 8;//projectile Dispatch
                        //checking if the SpaceShip collided with any of the projectiled objects
                        if (picSpaceShip.Bounds.IntersectsWith(picProjectile5.Bounds)) collisionCheck();
                    }
                    //This is making sure that if the projectile reached the ends of the form
                    if (picProjectile5.Top > 610)
                    {
                        picProjectile5.Visible = false;//making image invisible
                        picProjectile7.Visible = true;//making image visible after projectile 5 reaches end of the form
                        picProjectile7.Top += projectileDispatch + 11;//projectile Dispatch
                        //checking if the SpaceShip collided with any of the projectiled objects
                        if (picSpaceShip.Bounds.IntersectsWith(picProjectile7.Bounds)) collisionCheck();
                    }
                    //This is making sure that if the projectile reached the ends of the form
                    if (picProjectile7.Top > 610)
                    {
                        picProjectile7.Visible = false;//making image invisible
                        //moving the pictureboxes to their initial location before starting the next level
                        picProjectile1.Location = new Point(1, 3);
                        picProjectile2.Location = new Point(74, 3);
                        picProjectile3.Location = new Point(147, 3);
                        picProjectile4.Location = new Point(220, 3);
                        picProjectile5.Location = new Point(293, 3);
                        picProjectile6.Location = new Point(363, 3);
                        picProjectile7.Location = new Point(436, 3);
                        picProjectile8.Location = new Point(509, 3);
                        picProjectile9.Location = new Point(582, 3);
                        picProjectile10.Location = new Point(655, 3);
                        picProjectile11.Location = new Point(728, 3);
                        Round = 1;//Refreshing the rounds, because after advancing to the next level, the user will start Round one of that level
                        level++;//proceeding to the next level
                    }

                    //making the images visible after rendering their visibilty
                    picProjectile8.Visible = true;
                    //projectile Dispatch
                    picProjectile8.Top += projectileDispatch + 2;
                    //Making the other images invisible
                    picProjectile1.Visible = false;
                    picProjectile2.Visible = false;
                    picProjectile3.Visible = false;
                    picProjectile4.Visible = false;
                    picProjectile6.Visible = false;
                    picProjectile9.Visible = false;
                    picProjectile10.Visible = false;
                    picProjectile11.Visible = false;
                }
            }
            //checking if the user reached level 3, Saturn
            else if (level == 3)
            {
                planet = "Saturn";//assigning the string plnet to Saturn, as we are in the saturn level
                //Changing the images in the pictureboxes as they proceed to level 3, which is saturn
                //I changed them to the index 3 which is an asteroid 
                picProjectile1.Image = listProjectileImages.Images[3];
                picProjectile2.Image = listProjectileImages.Images[3];
                picProjectile3.Image = listProjectileImages.Images[3];
                picProjectile4.Image = listProjectileImages.Images[3];
                picProjectile5.Image = listProjectileImages.Images[3];
                picProjectile6.Image = listProjectileImages.Images[3];
                picProjectile7.Image = listProjectileImages.Images[3];
                picProjectile8.Image = listProjectileImages.Images[3];
                picProjectile9.Image = listProjectileImages.Images[3];
                picProjectile10.Image = listProjectileImages.Images[3];
                picProjectile11.Image = listProjectileImages.Images[3];
                //beginning of the third level
                if (Round == 1)
                {
                    //checking if the SpaceShip collided with any of the projectiled objects
                    if (picSpaceShip.Bounds.IntersectsWith(picProjectile2.Bounds) ||
                        picSpaceShip.Bounds.IntersectsWith(picProjectile4.Bounds) ||
                        picSpaceShip.Bounds.IntersectsWith(picProjectile7.Bounds) ||
                        picSpaceShip.Bounds.IntersectsWith(picProjectile10.Bounds))
                    {
                        collisionCheck();//a method that I made to run code in the event of a collision
                    }
                    //checking if the images leave the form
                    if (picProjectile4.Top > 610)
                    {
                        picProjectile4.Visible = false;//making image invisible
                    }
                    //checking if the images leave the form
                    if (picProjectile7.Top > 610)
                    {
                        picProjectile7.Visible = false;//making image invisible
                    }
                    //checking if the images leave the form
                    if (picProjectile2.Top > 610)
                    {
                        picProjectile2.Visible = false;//making image invisible
                    }
                    //checking if the images leave the form
                    if (picProjectile10.Top > 610)
                    {
                        picProjectile10.Visible = false;//making image invisible
                        Round++;//proceeding to the next Round
                    }

                    //making the images visible after rendering their visibilty
                    picProjectile2.Visible = true;
                    picProjectile4.Visible = true;
                    picProjectile7.Visible = true;
                    picProjectile10.Visible = true;
                    //projectile Dispatch
                    picProjectile2.Top += projectileDispatch + 12;
                    picProjectile4.Top += projectileDispatch + 22;
                    picProjectile7.Top += projectileDispatch + 14;
                    picProjectile10.Top += projectileDispatch + 7;
                    //Making the other images invisible
                    picProjectile1.Visible = false;
                    picProjectile3.Visible = false;
                    picProjectile5.Visible = false;
                    picProjectile6.Visible = false;
                    picProjectile8.Visible = false;
                    picProjectile9.Visible = false;
                    picProjectile11.Visible = false;
                }
                //checking if the user reached Round 2
                else if(Round == 2)
                {
                    //checking if the SpaceShip collided with any of the projectiled objects
                    if (picSpaceShip.Bounds.IntersectsWith(picProjectile1.Bounds) ||
                        picSpaceShip.Bounds.IntersectsWith(picProjectile3.Bounds) ||
                        picSpaceShip.Bounds.IntersectsWith(picProjectile6.Bounds) ||
                        picSpaceShip.Bounds.IntersectsWith(picProjectile9.Bounds) ||
                        picSpaceShip.Bounds.IntersectsWith(picProjectile11.Bounds))
                    {
                        collisionCheck();//a method that I made to run code in the event of a collision
                    }

                    //checking if the images leave the form
                    if (picProjectile11.Top > 610)
                    {
                        picProjectile11.Visible = false;//making the image invisible
                    }
                    //checking if the images leave the form
                    if (picProjectile6.Top > 610)
                    {
                        picProjectile6.Visible = false;//making the image invisible
                    }
                    //checking if the images leave the form
                    if (picProjectile3.Top > 610)
                    {
                        picProjectile3.Visible = false;//making the image invisible
                    }
                    //checking if the images leave the form
                    if (picProjectile1.Top > 610)
                    {
                        picProjectile1.Visible = false;//making the image invisible
                    }
                    //checking if the images leave the form
                    if (picProjectile9.Top > 610)
                    {
                        picProjectile9.Visible = false;//making the image invisible
                        Round++;//proceeding to the next Round
                    }

                    //making the images visible after rendering their visibilty
                    picProjectile1.Visible = true;
                    picProjectile3.Visible = true;
                    picProjectile6.Visible = true;
                    picProjectile9.Visible = true;
                    picProjectile11.Visible = true;
                    //projectile Dispatch
                    picProjectile1.Top += projectileDispatch + 20;
                    picProjectile3.Top += projectileDispatch + 22;
                    picProjectile6.Top += projectileDispatch + 32;
                    picProjectile9.Top += projectileDispatch + 14;
                    picProjectile11.Top += projectileDispatch + 37;
                    //Making the other images invisible
                    picProjectile2.Visible = false;
                    picProjectile4.Visible = false;
                    picProjectile5.Visible = false;
                    picProjectile7.Visible = false;
                    picProjectile8.Visible = false;
                    picProjectile10.Visible = false;
                }
                //checking if the user reached Round 3
                else if(Round == 3)
                {
                    //checking if the SpaceShip collided with any of the projectiled objects
                    if (picSpaceShip.Bounds.IntersectsWith(picProjectile2.Bounds) ||
                        picSpaceShip.Bounds.IntersectsWith(picProjectile3.Bounds) ||
                        picSpaceShip.Bounds.IntersectsWith(picProjectile5.Bounds) ||
                        picSpaceShip.Bounds.IntersectsWith(picProjectile7.Bounds) ||
                        picSpaceShip.Bounds.IntersectsWith(picProjectile10.Bounds) ||
                        picSpaceShip.Bounds.IntersectsWith(picProjectile11.Bounds))
                    {
                        collisionCheck();//a method that I made to run code in the event of a collision
                    }

                    //checking if the image leave the form
                    if (picProjectile7.Top > 610)
                    {
                        picProjectile7.Visible = false;//making the image invisible
                    }
                    //checking if the image leave the form
                    if (picProjectile5.Top > 610)
                    {
                        picProjectile5.Visible = false;//making the image invisible
                    }
                    //checking if the image leave the form
                    if (picProjectile3.Top > 610)
                    {
                        picProjectile3.Visible = false;//making the image invisible
                        picProjectile11.Visible = false;//making the image invisible
                    }
                    //checking if the image leave the form
                    if (picProjectile2.Top > 610)
                    {
                        picProjectile2.Visible = false;//making the image invisible
                        picProjectile10.Visible = false;//making the image invisible
                        //making images visible
                        picProjectile1.Visible = true;
                        picProjectile4.Visible = true;
                        picProjectile6.Visible = true;
                        picProjectile8.Visible = true;
                        picProjectile9.Visible = true;
                        //projectile Dispatch
                        picProjectile1.Top += projectileDispatch + 35;
                        picProjectile4.Top += projectileDispatch + 39;
                        picProjectile6.Top += projectileDispatch + 38;
                        picProjectile8.Top += projectileDispatch + 46;
                        picProjectile9.Top += projectileDispatch + 25;
                        //checking if the SpaceShip collided with any of the projectiled objects
                        //I placed this code here because I want the loser to lose once these asteroids hurl at their precious
                        //space ship and not when they are chilling at their intial locations being invisible
                        if (picSpaceShip.Bounds.IntersectsWith(picProjectile1.Bounds) ||
                            picSpaceShip.Bounds.IntersectsWith(picProjectile4.Bounds) ||
                            picSpaceShip.Bounds.IntersectsWith(picProjectile6.Bounds) ||
                            picSpaceShip.Bounds.IntersectsWith(picProjectile8.Bounds) ||
                            picSpaceShip.Bounds.IntersectsWith(picProjectile9.Bounds))
                        {
                            collisionCheck();//a method that I made to run code in the event of a collision
                        }

                    }
                    //checking if the image leave the form
                    if (picProjectile1.Top > 610)
                    {
                        picProjectile1.Visible = false;//making the image invisible
                    }
                    //checking if the image leave the form
                    if (picProjectile4.Top > 610)
                    {
                        picProjectile4.Visible = false;//making the image invisible
                    }
                    //checking if the image leave the form
                    if (picProjectile6.Top > 610)
                    { 
                        picProjectile6.Visible = false;//making the image invisible
                    }
                    //checking if the image leave the form
                    if (picProjectile8.Top > 610)
                    {
                        picProjectile8.Visible = false;//making the image invisible
                    }
                    //checking if the image leave the form
                    if (picProjectile9.Top > 610)
                    {
                        picProjectile9.Visible = false;//making the image invisible
                        //placing all pictureboxes back to initial locations
                        picProjectile1.Location = new Point(1, 3);
                        picProjectile2.Location = new Point(74, 3);
                        picProjectile3.Location = new Point(147, 3);
                        picProjectile4.Location = new Point(220, 3);
                        picProjectile5.Location = new Point(293, 3);
                        picProjectile6.Location = new Point(363, 3);
                        picProjectile7.Location = new Point(436, 3);
                        picProjectile8.Location = new Point(509, 3);
                        picProjectile9.Location = new Point(582, 3);
                        picProjectile10.Location = new Point(655, 3);
                        picProjectile11.Location = new Point(728, 3);
                        level++;//Advancing to the next level
                        Round = 1;//refershing the Rounds
                    }

                    //making the images visible after rendering their visibilty
                    picProjectile2.Visible = true;
                    picProjectile3.Visible = true;
                    picProjectile5.Visible = true;
                    picProjectile7.Visible = true;
                    picProjectile10.Visible = true;
                    picProjectile11.Visible = true;
                    //projectile Dispatch
                    picProjectile2.Top += projectileDispatch + 25;
                    picProjectile3.Top += projectileDispatch + 27;
                    picProjectile5.Top += projectileDispatch + 39;
                    picProjectile7.Top += projectileDispatch + 41;
                    picProjectile10.Top += projectileDispatch + 25;
                    picProjectile11.Top += projectileDispatch + 27;
                }
            }

            //checking if the user reached to level 4, which is Jupiter
            else if (level == 4)
            {
                planet = "Jupiter";//assigning the string plant the name Jupiter to display in the label so the user know that they are in jupiter
                //Resizing all images to appear larger
                //It essentially resizes te pictureboxes length and widht to become larger in area and places it inside picsize
                Size picsize = new Size(87, 78);//I learnt this here --> (https://stackoverflow.com/questions/13377026/what-is-the-code-to-resize-a-picturebox-in-c/13377061)
                //I then took picsize and assigned it to all of the pictureboxes using .Size which specifies the height and width through the Size property 
                picProjectile1.Size = picsize;
                picProjectile2.Size = picsize;
                picProjectile3.Size = picsize;
                picProjectile4.Size = picsize;
                picProjectile5.Size = picsize;
                picProjectile6.Size = picsize;
                picProjectile7.Size = picsize;
                picProjectile8.Size = picsize;
                picProjectile9.Size = picsize;
                picProjectile10.Size = picsize;
                picProjectile11.Size = picsize;

                //New Round in Level 4(Jupiter)
                if(Round == 1)
                {
                    //checking if the SpaceShip collided with any of the projectiled objects
                    if (picSpaceShip.Bounds.IntersectsWith(picProjectile3.Bounds) ||
                        picSpaceShip.Bounds.IntersectsWith(picProjectile5.Bounds) ||
                        picSpaceShip.Bounds.IntersectsWith(picProjectile8.Bounds))
                    {
                        collisionCheck();//a method that I made to run code in the event of a collision
                    }

                    //checking if the image leaves the form
                    if (picProjectile3.Top > 610)
                    {
                        picProjectile3.Visible = false;//making image invisible
                    }
                    //checking if the image leaves the form
                    if (picProjectile5.Top > 610)
                    {
                        picProjectile5.Visible = false;//making image invisible
                    }
                    //checking if the image leaves the form
                    if (picProjectile8.Top > 610)
                    {
                        picProjectile8.Visible = false;//making image invisible
                        Round++;//advancing to the next Round
                    }

                    //making images visible
                    picProjectile3.Visible = true;
                    picProjectile5.Visible = true;
                    picProjectile8.Visible = true;
                    //projectileDispatch
                    picProjectile3.Top += projectileDispatch + 8;
                    picProjectile5.Top += projectileDispatch + 10;
                    picProjectile8.Top += projectileDispatch + 11;
                    //Making other images invisible
                    picProjectile1.Visible = false;
                    picProjectile2.Visible = false;
                    picProjectile4.Visible = false;
                    picProjectile6.Visible = false;
                    picProjectile7.Visible = false;
                    picProjectile9.Visible = false;
                    picProjectile10.Visible = false;
                    picProjectile11.Visible = false;
                }
                //checking if user advanced to Round 2
                else if(Round == 2)
                {
                    //checking if the SpaceShip collided with any of the projectiled objects
                    if (picSpaceShip.Bounds.IntersectsWith(picProjectile2.Bounds) ||
                        picSpaceShip.Bounds.IntersectsWith(picProjectile8.Bounds) ||
                        picSpaceShip.Bounds.IntersectsWith(picProjectile11.Bounds))
                    {
                        collisionCheck();//a method that I made to run code in the event of a collision
                    }

                    //checking if the images leave the form
                    if (picProjectile2.Top > 610)
                    {
                        picProjectile2.Visible = false;//making image invisible
                    }
                    //checking if the images leave the form
                    if (picProjectile8.Top > 610)
                    {
                        picProjectile8.Visible = false;//making image invisible
                    }
                    //checking if the images leave the form
                    if (picProjectile11.Top > 610)
                    {
                        picProjectile11.Visible = false;//making image invisible
                        Round++;//advancing to the next ROund
                    }

                    //making images visible
                    picProjectile2.Visible = true;
                    picProjectile8.Visible = true;
                    picProjectile11.Visible = true;
                    //projectile Dispatch
                    picProjectile2.Top += projectileDispatch + 18;
                    picProjectile8.Top += projectileDispatch + 24;
                    picProjectile11.Top += projectileDispatch + 21;
                    //Making other images invisible
                    picProjectile1.Visible = false;
                    picProjectile3.Visible = false;
                    picProjectile4.Visible = false;
                    picProjectile5.Visible = false;
                    picProjectile6.Visible = false;
                    picProjectile7.Visible = false;
                    picProjectile9.Visible = false;
                    picProjectile10.Visible = false;
                }
                //checking if the user advanced to the next Round
                else if(Round == 3)
                {
                    //checking if the SpaceShip collided with any of the projectiled objects
                    if (picSpaceShip.Bounds.IntersectsWith(picProjectile1.Bounds) ||
                        picSpaceShip.Bounds.IntersectsWith(picProjectile3.Bounds) ||
                        picSpaceShip.Bounds.IntersectsWith(picProjectile5.Bounds))
                    {
                        collisionCheck();//a method that I made to run code in the event of a collision
                    }

                    //checking if the image leaves the form
                    if (picProjectile1.Top > 610)
                    {
                        picProjectile1.Visible = false;//making image invisible
                    }
                    //checking if the image leaves the form
                    if (picProjectile3.Top > 610)
                    {
                        picProjectile3.Visible = false;//making image invisible
                    }
                    //checking if the image leaves the form
                    if (picProjectile5.Top > 610)
                    {
                        picProjectile5.Visible = false;//making image invisible
                        //after the first wave, I want to aambush with a comet crash
                        picProjectile4.Visible = true;//making image visible
                        picProjectile8.Visible = true;//making image visible
                        picProjectile9.Visible = true;//making image visible
                        //projectile Dispatch
                        picProjectile4.Top += projectileDispatch + 38;
                        picProjectile8.Top += projectileDispatch + 24;
                        picProjectile9.Top += projectileDispatch + 31;
                        //checking if the SpaceShip collided with any of the projectiled objects
                        if (picSpaceShip.Bounds.IntersectsWith(picProjectile4.Bounds) ||
                            picSpaceShip.Bounds.IntersectsWith(picProjectile8.Bounds) ||
                            picSpaceShip.Bounds.IntersectsWith(picProjectile9.Bounds))
                        {
                            collisionCheck();//a method that I made to run code in the event of a collision
                        }
                    }
                    //checking if the image leaves the form
                    if (picProjectile4.Top > 610)
                    {
                        picProjectile4.Visible = false;//making image invisible
                    }
                    //checking if the image leaves the form
                    if (picProjectile9.Top > 610)
                    {
                        picProjectile9.Visible = false;//making image invisible
                    }
                    //checking if the image leaves the form
                    if (picProjectile8.Top > 610)
                    {
                        picProjectile8.Visible = false;//making image invisible
                        //resizing all pictureboxes back to initial size
                        picsize = new Size(67, 58);
                        picProjectile1.Size = picsize;
                        picProjectile2.Size = picsize;
                        picProjectile3.Size = picsize;
                        picProjectile4.Size = picsize;
                        picProjectile5.Size = picsize;
                        picProjectile6.Size = picsize;
                        picProjectile7.Size = picsize;
                        picProjectile8.Size = picsize;
                        picProjectile9.Size = picsize;
                        picProjectile10.Size = picsize;
                        picProjectile11.Size = picsize;
                        //placing all pictureboxes back to initial locations
                        picProjectile1.Location = new Point(1, 3);
                        picProjectile2.Location = new Point(74, 3);
                        picProjectile3.Location = new Point(147, 3);
                        picProjectile4.Location = new Point(220, 3);
                        picProjectile5.Location = new Point(293, 3);
                        picProjectile6.Location = new Point(363, 3);
                        picProjectile7.Location = new Point(436, 3);
                        picProjectile8.Location = new Point(509, 3);
                        picProjectile9.Location = new Point(582, 3);
                        picProjectile10.Location = new Point(655, 3);
                        picProjectile11.Location = new Point(728, 3);
                        Round = 1;//refreshing the round since we are poroceeding to level 5
                        level++;//proceeding to next level
                    }

                    //making images visible
                    picProjectile1.Visible = true;
                    picProjectile3.Visible = true;
                    picProjectile5.Visible = true;
                    //projectileDispatch
                    picProjectile1.Top += projectileDispatch + 18;
                    picProjectile3.Top += projectileDispatch + 24;
                    picProjectile5.Top += projectileDispatch + 21;
                    //Making other images invisible
                    picProjectile2.Visible = false;
                    picProjectile6.Visible = false;
                    picProjectile7.Visible = false;
                    picProjectile10.Visible = false;
                    picProjectile11.Visible = false;
                }
            }
            //checking if the user reached level 5
            else if (level == 5)//level 5, mars
            {
                planet = "Mars";//assigning the string plant to "Mars" to indicate the user in in the mars level
                //Changing the images in the pictureboxes as they proceed to level 5, which is mars
                picProjectile1.Image = listProjectileImages.Images[0];
                picProjectile2.Image = listProjectileImages.Images[0];
                picProjectile3.Image = listProjectileImages.Images[0];
                picProjectile4.Image = listProjectileImages.Images[0];
                picProjectile5.Image = listProjectileImages.Images[0];
                picProjectile6.Image = listProjectileImages.Images[0];
                picProjectile7.Image = listProjectileImages.Images[0];
                picProjectile8.Image = listProjectileImages.Images[0];
                picProjectile9.Image = listProjectileImages.Images[0];
                picProjectile10.Image = listProjectileImages.Images[0];
                picProjectile11.Image = listProjectileImages.Images[0];
                //beginning of round 1
                if (Round == 1)
                {
                    //checking if the SpaceShip collided with any of the projectiled objects
                    if (picSpaceShip.Bounds.IntersectsWith(picProjectile5.Bounds) ||
                        picSpaceShip.Bounds.IntersectsWith(picProjectile8.Bounds) ||
                        picSpaceShip.Bounds.IntersectsWith(picProjectile10.Bounds))
                    {
                        collisionCheck();//a method that I made to run code in the event of a collision
                    }

                    //checking if the images leave the form
                    if (picProjectile5.Top > 610)
                    {
                        picProjectile5.Visible = false;//making image invisible
                    }
                    //checking if the images leave the form
                    if (picProjectile8.Top > 610)
                    {
                        picProjectile8.Visible = false;//making image invisible
                    }
                    //checking if the images leave the form
                    if (picProjectile10.Top > 610)
                    {
                        picProjectile10.Visible = false;//making image invisible
                        Round++;//proceeding to the next Round
                    }

                    //making images visible
                    picProjectile5.Visible = true;
                    picProjectile8.Visible = true;
                    picProjectile10.Visible = true;
                    //projectileDispatch
                    picProjectile5.Top += projectileDispatch + 18;
                    picProjectile8.Top += projectileDispatch + 24;
                    picProjectile10.Top += projectileDispatch + 14;
                    //making the other images invisible
                    picProjectile1.Visible = false;
                    picProjectile2.Visible = false;
                    picProjectile3.Visible = false;
                    picProjectile4.Visible = false;
                    picProjectile6.Visible = false;
                    picProjectile7.Visible = false;
                    picProjectile9.Visible = false;
                    picProjectile11.Visible = false;
                }

                //checking if user reached Round 2
                else if(Round == 2)
                {
                    //checking if the SpaceShip collided with any of the projectiled objects
                    if (picSpaceShip.Bounds.IntersectsWith(picDiagonalProjectile3.Bounds) ||
                        picSpaceShip.Bounds.IntersectsWith(picDiagonalProjectile2.Bounds))
                    {
                        collisionCheck();//a method that I made to run code in the event of a collision
                    }

                    //checking if the images leave the form
                    //.Left is the location of the picture's X-coordinate
                    //This essentially checks if the Image has left the form on the left
                    //800 is the value of the forms width length, so if it reaches that length, then it would be considered to be out of bounds
                    if (picDiagonalProjectile3.Top < 0 || picDiagonalProjectile3.Left > 800)//since we are subtracting the images y coordinates, I have to make sure that y
                                                                                            //doesnt reach a value smaller than 0, because then it would be out of bounds
                    {
                        picDiagonalProjectile3.Visible = false;//making image imvisible
                    }
                    //checking if the images leave the form
                    if (picDiagonalProjectile2.Top < 0 || picDiagonalProjectile2.Left < 0)//since we are subtracting the images x and y
                                                                                          //coordinates, I have to make sure that either coordinate doesnt reach a value smaller than 0, because then it would 
                                                                                          //be out of bounds
                    {
                        picDiagonalProjectile2.Visible = false;//making image imvisible
                        picDiagonalProjectile2.Location = new Point(728, 359);//putting the images that I used back to their initial location
                        picDiagonalProjectile3.Location = new Point(1, 359);//putting the images that I used back to their initial location
                        Round++;//proceeding to the next round
                    }

                    //setting the picture boxes to an image since i havent used them this whole time yet
                    picDiagonalProjectile2.Image = listProjectileImages.Images[0];
                    picDiagonalProjectile3.Image = listProjectileImages.Images[0];
                    //making the images visible
                    picDiagonalProjectile2.Visible = true;
                    picDiagonalProjectile3.Visible = true;
                    //projectileDispatch
                    picDiagonalProjectile2.Top -= projectileDispatch + 18;//this will minimize the y coordinate value
                    picDiagonalProjectile2.Left -= projectileDispatch + 18;//this will minimize the x coordinate value
                                                                           //together they make the image move diagonally
                    picDiagonalProjectile3.Top -= projectileDispatch + 23;//this will minimize the y coordinate value
                    picDiagonalProjectile3.Left += projectileDispatch + 23;//this will accumilate the x coordinate value
                                                                           //together they make the image move diagonally

                    //making the images visible after rendering their visibilty in round 3
                    picProjectile1.Visible = false;
                    picProjectile2.Visible = false;
                    picProjectile3.Visible = false;
                    picProjectile4.Visible = false;
                    picProjectile5.Visible = false;
                    picProjectile6.Visible = false;
                    picProjectile7.Visible = false;
                    picProjectile8.Visible = false;
                    picProjectile9.Visible = false;
                    picProjectile10.Visible = false;
                    picProjectile11.Visible = false;
                }
                //checking if user reached Round 3
                else if (Round == 3)
                {
                    //checking if the SpaceShip collided with any of the projectiled objects
                    if (picSpaceShip.Bounds.IntersectsWith(picProjectile1.Bounds) ||
                        picSpaceShip.Bounds.IntersectsWith(picProjectile4.Bounds) ||
                        picSpaceShip.Bounds.IntersectsWith(picProjectile6.Bounds) ||
                        picSpaceShip.Bounds.IntersectsWith(picProjectile11.Bounds) ||
                        picSpaceShip.Bounds.IntersectsWith(picDiagonalProjectile2.Bounds) || 
                        picSpaceShip.Bounds.IntersectsWith(picDiagonalProjectile3.Bounds))
                    {
                        collisionCheck();//a method that I made to run code in the event of a collision
                    }

                    //checking if the images leave the form
                    if(picProjectile11.Top > 610)
                    {
                        //making image invisible
                        picProjectile11.Visible = false;//making image invisible
                    }
                    //checking if the images leave the form
                    if (picProjectile1.Top > 610)
                    {
                        picProjectile1.Visible = false;//making image invisible
                        picProjectile6.Visible = false;//making image invisible
                        //since both images 1 and 6 move at the same rate, they both should be invisible when either when of them reach the end
                    }
                    //checking if the images leave the form
                    if (picProjectile4.Top > 610)
                    {
                        picProjectile4.Visible = false;//making image invisible
                    }

                    //.Left is the location of the picture's X-coordinate
                    //This essentially checks if the Image has left the form on the left
                    if (picDiagonalProjectile3.Top < 0 || picDiagonalProjectile3.Left < 0)//since we are subtracting the images y coordinates, I have to make sure that y
                                                                                          //doesnt reach a value smaller than 0, because then it would be out of bounds
                    {
                        picDiagonalProjectile3.Visible = false;//making image invisible
                        
                    }

                    if (picDiagonalProjectile2.Top < 0 || picDiagonalProjectile2.Left < 0)//since we are subtracting the images x and y
                                                                                          //coordinates, I have to make sure that either coordinate doesnt reach a value smaller than 0, because then it would 
                                                                                          //be out of bounds
                    {
                        picDiagonalProjectile2.Visible = false;//making image invisible
                        //placing all pictureboxes back to initial locations
                        picProjectile1.Location = new Point(1, 3);
                        picProjectile2.Location = new Point(74, 3);
                        picProjectile3.Location = new Point(147, 3);
                        picProjectile4.Location = new Point(220, 3);
                        picProjectile5.Location = new Point(293, 3);
                        picProjectile6.Location = new Point(363, 3);
                        picProjectile7.Location = new Point(436, 3);
                        picProjectile8.Location = new Point(509, 3);
                        picProjectile9.Location = new Point(582, 3);
                        picProjectile10.Location = new Point(655, 3);
                        picProjectile11.Location = new Point(728, 3);
                        Round = 1;//refreshing the rounds
                        level++;//proceeding to next level
                    }

                    //making the images visible
                    picProjectile1.Visible = true;
                    picProjectile4.Visible = true;
                    picProjectile6.Visible = true;
                    picProjectile11.Visible = true;
                    picDiagonalProjectile2.Visible = true;
                    picDiagonalProjectile3.Visible = true;
                    //projectile Dispatch
                    picProjectile1.Top += projectileDispatch + 40;
                    picProjectile4.Top += projectileDispatch + 48;
                    picProjectile6.Top += projectileDispatch + 40;
                    picProjectile11.Top += projectileDispatch + 54;
                    //projectileDispatch of abushing diagonal ufo's
                    picDiagonalProjectile2.Top -= projectileDispatch + 18;//this will minimize the x coordinate value
                    picDiagonalProjectile2.Left -= projectileDispatch + 18;//this will minimize the y coordinate value
                                                                           //together they make the image move diagonally
                    picDiagonalProjectile3.Top -= projectileDispatch + 23;//this will minimize the x coordinate value
                    picDiagonalProjectile3.Left += projectileDispatch + 23;//this will minimize the y coordinate value
                                                                           //together they make the image move diagonally
                                                                           //making images visible
                    //making the other images invisible
                    picProjectile2.Visible = false;
                    picProjectile3.Visible = false;
                    picProjectile5.Visible = false;
                    picProjectile7.Visible = false;
                    picProjectile8.Visible = false;
                    picProjectile9.Visible = false;
                    picProjectile10.Visible = false;
                }
            }
            //checking if user advanced to level 6, earth
            else if (level == 6)
            {
                planet = "Earth";//assigning the string plant to the word Earth to indicaate that we are on the earth level to the user
                //Changing the images in the pictureboxes as they proceed to level 6, which is Earth
                picProjectile1.Image = listProjectileImages.Images[4];
                picProjectile2.Image = listProjectileImages.Images[4];
                picProjectile3.Image = listProjectileImages.Images[4];
                picProjectile4.Image = listProjectileImages.Images[4];
                picProjectile5.Image = listProjectileImages.Images[4];
                picProjectile6.Image = listProjectileImages.Images[4];
                picProjectile7.Image = listProjectileImages.Images[4];
                picProjectile8.Image = listProjectileImages.Images[4];
                picProjectile9.Image = listProjectileImages.Images[4];
                picProjectile10.Image = listProjectileImages.Images[4];
                picProjectile11.Image = listProjectileImages.Images[4];
                //beginning of first Round in level 6, Earth
                if (Round == 1)
                {
                    //checking if SpaceShip collided with the projectiles
                    if (picSpaceShip.Bounds.IntersectsWith(picProjectile1.Bounds) ||
                        picSpaceShip.Bounds.IntersectsWith(picProjectile3.Bounds) ||
                        picSpaceShip.Bounds.IntersectsWith(picProjectile11.Bounds))
                    {
                        collisionCheck();//a method that I made to run code in the event of a collision
                    }

                    //checking if images left the form
                    if (picProjectile3.Top > 610)
                    {
                        picProjectile3.Visible = false;//making image invisible
                    }
                    //checking if images left the form
                    if (picProjectile1.Top > 610)
                    {
                        picProjectile1.Visible = false;//making image invisible
                    }
                    //checking if images left the form
                    if (picProjectile11.Top > 610)
                    {
                        picProjectile11.Visible = false;//making image invisible
                        Round++;//proceeding to the next Round
                    }

                    //making the images visible
                    picProjectile1.Visible = true;
                    picProjectile3.Visible = true;
                    picProjectile11.Visible = true;
                    //projectile Dispatch
                    picProjectile1.Top += projectileDispatch + 58;
                    picProjectile3.Top += projectileDispatch + 60;
                    picProjectile11.Top += projectileDispatch + 52;
                    //making the other images invisible
                    picProjectile2.Visible = false;
                    picProjectile4.Visible = false;
                    picProjectile5.Visible = false;
                    picProjectile6.Visible = false;
                    picProjectile7.Visible = false;
                    picProjectile8.Visible = false;
                    picProjectile9.Visible = false;
                    picProjectile10.Visible = false;
                    picDiagonalProjectile2.Visible = false;
                    picDiagonalProjectile3.Visible = false;
                }
                //chekcing if the user reached Round 2
                else if (Round == 2)
                {
                    //checking if SpaceShip collided with the projectiles
                    if (picSpaceShip.Bounds.IntersectsWith(picProjectile2.Bounds) ||
                        picSpaceShip.Bounds.IntersectsWith(picProjectile4.Bounds) ||
                        picSpaceShip.Bounds.IntersectsWith(picProjectile8.Bounds) ||
                        picSpaceShip.Bounds.IntersectsWith(picProjectile9.Bounds) ||
                        picSpaceShip.Bounds.IntersectsWith(picProjectile10.Bounds))
                    {
                        collisionCheck();//a method that I made to run code in the event of a collision
                    }

                    //checking if images left the form
                    if (picProjectile9.Top > 610)
                    {
                        picProjectile9.Visible = false;//making image invisible
                    }
                    //checking if images left the form
                    if (picProjectile8.Top > 610)
                    {
                        picProjectile8.Visible = false;//making image invisible
                    }
                    //checking if images left the form
                    if (picProjectile4.Top > 610)
                    {
                        picProjectile4.Visible = false;//making image invisible
                    }
                    //checking if images left the form
                    if (picProjectile10.Top > 610)
                    {
                        picProjectile10.Visible = false;//making image invisible
                    }
                    //checking if images left the form
                    if (picProjectile2.Top > 610)
                    {
                        picProjectile2.Visible = false;//making image invisible
                        //placing pictureboxes back to initial locations
                        picProjectile2.Location = new Point(74, 3);
                        picProjectile3.Location = new Point(147, 3);
                        picProjectile4.Location = new Point(220, 3);
                        picProjectile9.Location = new Point(582, 3);
                        picProjectile10.Location = new Point(655, 3);
                        picProjectile11.Location = new Point(728, 3);
                        Round++;//proceeding to next round
                    }

                    //making the images visible
                    picProjectile2.Visible = true;
                    picProjectile4.Visible = true;
                    picProjectile8.Visible = true;
                    picProjectile9.Visible = true;
                    picProjectile10.Visible = true;
                    //projectile Dispatch
                    picProjectile2.Top += projectileDispatch + 58;
                    picProjectile4.Top += projectileDispatch + 66;
                    picProjectile8.Top += projectileDispatch + 68;
                    picProjectile9.Top += projectileDispatch + 73;
                    picProjectile10.Top += projectileDispatch + 62;
                    //making the other images invisible
                    picProjectile1.Visible = false;
                    picProjectile3.Visible = false;
                    picProjectile5.Visible = false;
                    picProjectile6.Visible = false;
                    picProjectile7.Visible = false;
                    picProjectile11.Visible = false;
                }
                //checking if user advanced to Round 3
                else if (Round == 3)
                {
                    //checking if SpaceShip collided with the projectiles
                    if (picSpaceShip.Bounds.IntersectsWith(picProjectile2.Bounds) ||
                       picSpaceShip.Bounds.IntersectsWith(picProjectile4.Bounds) ||
                       picSpaceShip.Bounds.IntersectsWith(picProjectile8.Bounds) ||
                       picSpaceShip.Bounds.IntersectsWith(picProjectile9.Bounds) ||
                       picSpaceShip.Bounds.IntersectsWith(picProjectile10.Bounds))
                    {
                        collisionCheck();//a method that I made to run code in the event of a collision
                    }

                    //checking if images left the form
                    if (picProjectile9.Top > 610)
                    {
                        picProjectile9.Visible = false;//making image invisible
                    }
                    //checking if images left the form
                    if (picProjectile11.Top > 610)
                    {
                        picProjectile11.Visible = false;//making image invisible
                    }
                    //checking if images left the form
                    if (picProjectile2.Top > 610)
                    {
                        picProjectile2.Visible = false;//making image invisible
                    }
                    //checking if images left the form
                    if (picProjectile4.Top > 610)
                    {
                        picProjectile4.Visible = false;//making image invisible
                    }
                    //checking if images left the form
                    if (picProjectile3.Top > 610)
                    {
                        picProjectile3.Visible = false;//making image invisible
                    }
                    //checking if images left the form
                    if (picProjectile10.Top > 610)
                    {
                        picProjectile10.Visible = false;//making image invisible
                        //placing all pictureboxes back to initial locations
                        picProjectile1.Location = new Point(1, 3);
                        picProjectile2.Location = new Point(74, 3);
                        picProjectile3.Location = new Point(147, 3);
                        picProjectile4.Location = new Point(220, 3);
                        picProjectile5.Location = new Point(293, 3);
                        picProjectile6.Location = new Point(363, 3);
                        picProjectile7.Location = new Point(436, 3);
                        picProjectile8.Location = new Point(509, 3);
                        picProjectile9.Location = new Point(582, 3);
                        picProjectile10.Location = new Point(655, 3);
                        picProjectile11.Location = new Point(728, 3);
                        Round = 1;//refreshing rounds
                        level++;//proceeding to the next level
                    }

                    //making the images visible
                    picProjectile2.Visible = true;
                    picProjectile3.Visible = true;
                    picProjectile4.Visible = true;
                    picProjectile9.Visible = true;
                    picProjectile10.Visible = true;
                    picProjectile11.Visible = true;
                    //projectile Dispatch
                    picProjectile2.Top += projectileDispatch + 78;
                    picProjectile3.Top += projectileDispatch + 76;
                    picProjectile4.Top += projectileDispatch + 77;
                    picProjectile9.Top += projectileDispatch + 88;
                    picProjectile10.Top += projectileDispatch + 73;
                    picProjectile11.Top += projectileDispatch + 82;
                    //making the other images invisible
                    picProjectile1.Visible = false;
                    picProjectile5.Visible = false;
                    picProjectile6.Visible = false;
                    picProjectile7.Visible = false;
                    picProjectile8.Visible = false;
                }
            }
            //checking if the user avanced to the next level, venus
            else if (level == 7)
            {
                planet = "Venus";//assigning the string planet to the word Venus to indicate to the user that they are in the Venus level
                //Changing the images in the pictureboxes as they proceed to level 7, which is Venus
                picProjectile1.Image = listProjectileImages.Images[2];
                picProjectile2.Image = listProjectileImages.Images[3];
                picProjectile3.Image = listProjectileImages.Images[3];
                picProjectile4.Image = listProjectileImages.Images[2];
                picProjectile5.Image = listProjectileImages.Images[3];
                picProjectile6.Image = listProjectileImages.Images[2];
                picProjectile7.Image = listProjectileImages.Images[3];
                picProjectile8.Image = listProjectileImages.Images[3];
                picProjectile9.Image = listProjectileImages.Images[2];
                picProjectile10.Image = listProjectileImages.Images[2];
                picProjectile11.Image = listProjectileImages.Images[3];
                //beginning of level 7 in round 1
                if (Round == 1)
                {
                    //checking if SpaceShip collided with the projectiles
                    if (picSpaceShip.Bounds.IntersectsWith(picProjectile3.Bounds) ||
                       picSpaceShip.Bounds.IntersectsWith(picProjectile4.Bounds) ||
                       picSpaceShip.Bounds.IntersectsWith(picProjectile10.Bounds) ||
                       picSpaceShip.Bounds.IntersectsWith(picProjectile11.Bounds))
                    {
                        collisionCheck();//a method that I made to run code in the event of a collision
                    }

                    //checking if images left the form
                    if (picProjectile4.Top > 610)
                    {
                        picProjectile4.Visible = false;//making image invisible
                    }
                    //checking if images left the form
                    if (picProjectile3.Top > 610)
                    {
                        picProjectile3.Visible = false;//making image invisible
                    }
                    //checking if images left the form
                    if (picProjectile10.Top > 610)
                    {
                        picProjectile10.Visible = false;//making image invisible
                    }
                    //checking if images left the form
                    if (picProjectile11.Top > 610)
                    {
                        picProjectile11.Visible = false;//making image invisible
                        Round++;//refreshing round
                    }

                    //making the images visible
                    picProjectile3.Visible = true;
                    picProjectile4.Visible = true;
                    picProjectile10.Visible = true;
                    picProjectile11.Visible = true;
                    //projectile Dispatch
                    picProjectile3.Top += projectileDispatch + 86;
                    picProjectile4.Top += projectileDispatch + 87;
                    picProjectile10.Top += projectileDispatch + 83;
                    picProjectile11.Top += projectileDispatch + 82;
                    //making the other images invisible
                    picProjectile1.Visible = false;
                    picProjectile2.Visible = false;
                    picProjectile5.Visible = false;
                    picProjectile6.Visible = false;
                    picProjectile7.Visible = false;
                    picProjectile8.Visible = false;
                    picProjectile9.Visible = false;
                }
                //Checking if user advanced to the next Round
                else if (Round == 2)
                {
                    //checking if SpaceShip collided with the projectiles
                    if (picSpaceShip.Bounds.IntersectsWith(picProjectile1.Bounds) ||
                       picSpaceShip.Bounds.IntersectsWith(picProjectile2.Bounds) ||
                       picSpaceShip.Bounds.IntersectsWith(picProjectile5.Bounds) ||
                       picSpaceShip.Bounds.IntersectsWith(picProjectile6.Bounds))
                    {
                        collisionCheck();//a method that I made to run code in the event of a collision
                    }
                    //checking if images left the form
                    if (picProjectile2.Top > 610)
                    {
                        picProjectile2.Visible = false;//making image invisible
                    }
                    //checking if images left the form
                    if (picProjectile5.Top > 610)
                    {
                        picProjectile5.Visible = false;//making image invisible
                    }
                    //checking if images left the form
                    if (picProjectile6.Top > 610)
                    {
                        picProjectile6.Visible = false;//making image invisible
                    }
                    //checking if images left the form
                    if (picProjectile1.Top > 610)
                    {
                        picProjectile1.Visible = false;//making image invisible
                        Round++;//proceeding to the next round
                    }

                    //making the images visible
                    picProjectile1.Visible = true;
                    picProjectile2.Visible = true;
                    picProjectile5.Visible = true;
                    picProjectile6.Visible = true;
                    //projectile Dispatch
                    picProjectile1.Top += projectileDispatch + 90;
                    picProjectile2.Top += projectileDispatch + 97;
                    picProjectile5.Top += projectileDispatch + 93;
                    picProjectile6.Top += projectileDispatch + 92;
                    //making the other images invisible
                    picProjectile3.Visible = false;
                    picProjectile4.Visible = false;
                    picProjectile7.Visible = false;
                    picProjectile8.Visible = false;
                    picProjectile9.Visible = false;
                    picProjectile10.Visible = false;
                    picProjectile11.Visible = false;
                }
                //checking if image advanced to Round 3
                else if(Round == 3)
                {
                    //checking if SpaceShip collided with the projectiles
                    if (picSpaceShip.Bounds.IntersectsWith(picProjectile7.Bounds) ||
                      picSpaceShip.Bounds.IntersectsWith(picProjectile8.Bounds) ||
                      picSpaceShip.Bounds.IntersectsWith(picProjectile9.Bounds))
                    {
                        collisionCheck();//a method that I made to run code in the event of a collision
                    }

                    //checking if images left the form
                    if (picProjectile8.Top > 610)
                    {
                        picProjectile8.Visible = false;//making image invisible
                    }
                    //checking if images left the form
                    if (picProjectile7.Top > 610)
                    { 
                        picProjectile7.Visible = false;//making image invisible
                    }
                    //checking if images left the form
                    if (picProjectile9.Top > 610)
                    {
                        picProjectile9.Visible = false;//making image invisible
                        //placing all pictureboxes back to initial locations
                        picProjectile1.Location = new Point(1, 3);
                        picProjectile2.Location = new Point(74, 3);
                        picProjectile3.Location = new Point(147, 3);
                        picProjectile4.Location = new Point(220, 3);
                        picProjectile5.Location = new Point(293, 3);
                        picProjectile6.Location = new Point(363, 3);
                        picProjectile7.Location = new Point(436, 3);
                        picProjectile8.Location = new Point(509, 3);
                        picProjectile9.Location = new Point(582, 3);
                        picProjectile10.Location = new Point(655, 3);
                        picProjectile11.Location = new Point(728, 3);
                        Round = 1;//refreshing rounds
                        level++;//proceeding to the next level
                    }

                    //making the images visible
                    picProjectile7.Visible = true;
                    picProjectile8.Visible = true;
                    picProjectile9.Visible = true;
                    //projectile Dispatch
                    picProjectile7.Top += projectileDispatch + 98;
                    picProjectile8.Top += projectileDispatch + 99;
                    picProjectile9.Top += projectileDispatch + 96;
                    //making the other images invisible
                    picProjectile1.Visible = false;
                    picProjectile2.Visible = false;
                    picProjectile3.Visible = false;
                    picProjectile4.Visible = false;
                    picProjectile5.Visible = false;
                    picProjectile6.Visible = false;
                    picProjectile10.Visible = false;
                    picProjectile11.Visible = false;
                }
            }
            //checking if user advanced to the next level, level 8(mercury)
            else if (level == 8)
            {
                planet = "Mercury";//assigning the string planet to the word Mercury to indicate to the iser that the are in thee Mercury levl
                //Changing the images in the pictureboxes as they proceed to level 8, which is Mercury
                picProjectile1.Image = listProjectileImages.Images[3];
                picProjectile2.Image = listProjectileImages.Images[3];
                picProjectile3.Image = listProjectileImages.Images[3];
                picProjectile4.Image = listProjectileImages.Images[3];
                picProjectile5.Image = listProjectileImages.Images[3];
                picProjectile6.Image = listProjectileImages.Images[3];
                picProjectile7.Image = listProjectileImages.Images[3];
                picProjectile8.Image = listProjectileImages.Images[3];
                picProjectile9.Image = listProjectileImages.Images[3];
                picProjectile10.Image = listProjectileImages.Images[3];
                picProjectile11.Image = listProjectileImages.Images[3];

                //beginning level 1 with the start of Round 1
                if (Round == 1)
                {
                    //checking if SpaceShip collided with the projectiles
                    if (picSpaceShip.Bounds.IntersectsWith(picProjectile3.Bounds) ||
                        picSpaceShip.Bounds.IntersectsWith(picProjectile5.Bounds))
                    {
                        collisionCheck();//a method that I made to run code in the event of a collision
                    }

                    //checking if images left the form
                    if (picProjectile3.Top > 610)
                    {
                        picProjectile3.Visible = false;//making image invisible
                    }
                    //checking if images left the form
                    if (picProjectile5.Top > 610)
                    {
                        picProjectile5.Visible = false;//making image invisible
                        Round++;//proceeding to the next Round
                    }

                    //making the images visible
                    picProjectile3.Visible = true;
                    picProjectile5.Visible = true;
                    //projectile Dispatch
                    picProjectile3.Top += projectileDispatch + 128;
                    picProjectile5.Top += projectileDispatch + 129;
                    //making the other images invisible
                    picProjectile1.Visible = false;
                    picProjectile2.Visible = false;
                    picProjectile4.Visible = false;
                    picProjectile6.Visible = false;
                    picProjectile7.Visible = false;
                    picProjectile8.Visible = false;
                    picProjectile9.Visible = false;
                    picProjectile10.Visible = false;
                    picProjectile11.Visible = false;
                }
                //checking if user advamced to the next Round
                else if(Round == 2)
                {
                    //checking if SpaceShip collided with the projectiles
                    if (picSpaceShip.Bounds.IntersectsWith(picProjectile2.Bounds) ||
                      picSpaceShip.Bounds.IntersectsWith(picProjectile6.Bounds) ||
                      picSpaceShip.Bounds.IntersectsWith(picProjectile8.Bounds))
                    {
                        collisionCheck();//a method that I made to run code in the event of a collision
                    }

                    //checking if images left the form
                    if (picProjectile6.Top > 610)
                    {
                        picProjectile6.Visible = false;//making image invisible
                    }
                    //checking if images left the form
                    if (picProjectile8.Top > 610)
                    {
                        picProjectile8.Visible = false;//making image invisible
                    }
                    //checking if images left the form
                    if (picProjectile2.Top > 610)
                    {
                        picProjectile2.Visible = false;//making image invisible
                        Round++;//proceeding to the next Round
                    }

                    //making the images visible
                    picProjectile2.Visible = true;
                    picProjectile6.Visible = true;
                    picProjectile8.Visible = true;
                    //projectile Dispatch
                    picProjectile2.Top += projectileDispatch + 128;
                    picProjectile6.Top += projectileDispatch + 139;
                    picProjectile8.Top += projectileDispatch + 134;
                    //making the other images invisible
                    picProjectile1.Visible = false;
                    picProjectile3.Visible = false;
                    picProjectile4.Visible = false;
                    picProjectile5.Visible = false;
                    picProjectile7.Visible = false;
                    picProjectile9.Visible = false;
                    picProjectile10.Visible = false;
                    picProjectile11.Visible = false;
                }
                //checking if the user advanced to the next level
                else if (Round == 3)
                {
                    //checking if SpaceShip collided with the projectiles
                    if (picSpaceShip.Bounds.IntersectsWith(picProjectile1.Bounds) ||
                        picSpaceShip.Bounds.IntersectsWith(picProjectile4.Bounds) ||
                        picSpaceShip.Bounds.IntersectsWith(picProjectile10.Bounds))
                    {
                        collisionCheck();//a method that I made to run code in the event of a collision
                    }

                    //checking if images left the form 
                    if (picProjectile1.Top > 610)
                    {
                        picProjectile1.Visible = false;//making image invisible
                    }
                    //checking if images left the form 
                    if (picProjectile10.Top > 610)
                    {
                        picProjectile10.Visible = false;//making image invisible
                    }
                    //checking if images left the form 
                    if (picProjectile4.Top > 610)
                    {
                        picProjectile4.Visible = false;//making image invisible
                        Round++;//proceeding to the next Round
                    }

                    //making the images visible
                    picProjectile1.Visible = true;
                    picProjectile4.Visible = true;
                    picProjectile10.Visible = true;
                    //projectile Dispatch
                    picProjectile1.Top += projectileDispatch + 143;
                    picProjectile4.Top += projectileDispatch + 138;
                    picProjectile10.Top += projectileDispatch + 140;
                    //making the other images invisible
                    picProjectile2.Visible = false;
                    picProjectile3.Visible = false;
                    picProjectile5.Visible = false;
                    picProjectile6.Visible = false;
                    picProjectile7.Visible = false;
                    picProjectile8.Visible = false;
                    picProjectile9.Visible = false;
                    picProjectile11.Visible = false;
                }
                //checking if user advnaced to Round 4
                else if (Round == 4)
                {
                    //checking if SpaceShip collided with the projectiles
                    if (picSpaceShip.Bounds.IntersectsWith(picProjectile7.Bounds) ||
                        picSpaceShip.Bounds.IntersectsWith(picProjectile9.Bounds) ||
                        picSpaceShip.Bounds.IntersectsWith(picProjectile11.Bounds))
                    {
                        collisionCheck();//a method that I made to run code in the event of a collision
                    }

                    //checking if images left the form
                    if (picProjectile11.Top > 610)
                    {
                        picProjectile11.Visible = false;//making image invisible
                    }
                    //checking if images left the form
                    if (picProjectile7.Top > 610)
                    {
                        picProjectile7.Visible = false;//making image invisible
                    }
                    //checking if images left the form
                    if (picProjectile9.Top > 610)
                    {
                        picProjectile9.Visible = false;//making image invisible
                        //placing all pictureboxes back to initial locations
                        picProjectile1.Location = new Point(1, 3);
                        picProjectile2.Location = new Point(74, 3);
                        picProjectile3.Location = new Point(147, 3);
                        picProjectile4.Location = new Point(220, 3);
                        picProjectile5.Location = new Point(293, 3);
                        picProjectile6.Location = new Point(363, 3);
                        picProjectile7.Location = new Point(436, 3);
                        picProjectile8.Location = new Point(509, 3);
                        picProjectile9.Location = new Point(582, 3);
                        picProjectile10.Location = new Point(655, 3);
                        picProjectile11.Location = new Point(728, 3);
                        Round = 1;//refreshing the round
                        level++;//proceeding to the next level
                    }

                    //making the images visible
                    picProjectile7.Visible = true;
                    picProjectile9.Visible = true;
                    picProjectile11.Visible = true;
                    //projectile Dispatch
                    picProjectile7.Top += projectileDispatch + 148;
                    picProjectile9.Top += projectileDispatch + 149;
                    picProjectile11.Top += projectileDispatch + 144;
                    //making the other images invisible
                    picProjectile1.Visible = false;
                    picProjectile2.Visible = false;
                    picProjectile3.Visible = false;
                    picProjectile4.Visible = false;
                    picProjectile5.Visible = false;
                    picProjectile6.Visible = false;
                    picProjectile8.Visible = false;
                    picProjectile10.Visible = false;
                }
            }
            //checking if the user advnaced to level 9, the last level(sun)
            else if(level == 9)
            {
                planet = "Sun";//assigning the string planet to the word Sun to indicate to the user that they are in the sun level
                //Changing the images in the pictureboxes as they proceed to level 9, which is Sun
                picProjectile1.Image = listProjectileImages.Images[2];
                picProjectile2.Image = listProjectileImages.Images[2];
                picProjectile3.Image = listProjectileImages.Images[2];
                picProjectile4.Image = listProjectileImages.Images[2];
                picProjectile5.Image = listProjectileImages.Images[2];
                picProjectile6.Image = listProjectileImages.Images[2];
                picProjectile7.Image = listProjectileImages.Images[2];
                picProjectile8.Image = listProjectileImages.Images[2];
                picProjectile9.Image = listProjectileImages.Images[2];
                picProjectile10.Image = listProjectileImages.Images[2];
                picProjectile11.Image = listProjectileImages.Images[2];
                //beginning of Level 1 with Round 1
                if(Round == 1)
                {
                    //checking if SpaceShip collided with the projectiles
                    if (picSpaceShip.Bounds.IntersectsWith(picProjectile1.Bounds) ||
                        picSpaceShip.Bounds.IntersectsWith(picProjectile3.Bounds) ||
                        picSpaceShip.Bounds.IntersectsWith(picProjectile6.Bounds) ||
                        picSpaceShip.Bounds.IntersectsWith(picProjectile8.Bounds) ||
                        picSpaceShip.Bounds.IntersectsWith(picProjectile10.Bounds)||
                        picSpaceShip.Bounds.IntersectsWith(picProjectile11.Bounds))
                    {
                        collisionCheck();//a method that I made to run code in the event of a collision
                    }
                    //checking if images left the form
                    if (picProjectile6.Top > 610)
                    {
                        picProjectile6.Visible = false;//making images invisible
                    }
                    //checking if images left the form
                    if (picProjectile3.Top > 610)
                    {
                        picProjectile3.Visible = false;//making images invisible
                    }
                    //checking if images left the form
                    if (picProjectile1.Top > 610)
                    {
                        picProjectile1.Visible = false;//making images invisible
                    }
                    //checking if images left the form
                    if (picProjectile11.Top > 610)
                    {
                        picProjectile11.Visible = false;//making images invisible
                    }
                    //checking if images left the form
                    if (picProjectile10.Top > 610)
                    {
                        picProjectile10.Visible = false;//making images invisible
                    }
                    //checking if images left the form
                    if (picProjectile8.Top > 610)
                    {
                        picProjectile8.Visible = false;//checking if images left the form
                        //placing all pictureboxes back to initial locations
                        picProjectile1.Location = new Point(1, 3);
                        picProjectile8.Location = new Point(509, 3);
                        picProjectile11.Location = new Point(655, 3);
                        Round++;//advancing to the next round
                    }

                    //making the images visible
                    picProjectile1.Visible = true;
                    picProjectile3.Visible = true;
                    picProjectile6.Visible = true;
                    picProjectile8.Visible = true;
                    picProjectile10.Visible = true;
                    picProjectile11.Visible = true;
                    //projectile Dispatch
                    picProjectile1.Top += projectileDispatch + 158;
                    picProjectile3.Top += projectileDispatch + 159;
                    picProjectile6.Top += projectileDispatch + 164;
                    picProjectile8.Top += projectileDispatch + 154;
                    picProjectile10.Top += projectileDispatch + 155;
                    picProjectile11.Top += projectileDispatch + 157;
                    //making the other images invisible
                    picProjectile2.Visible = false;
                    picProjectile4.Visible = false;
                    picProjectile5.Visible = false;
                    picProjectile7.Visible = false;
                    picProjectile9.Visible = false;
                }
                //checking if the user advanced to Round 2
                else if(Round == 2)
                {
                    //checking if SpaceShip collided with the projectiles
                    if (picSpaceShip.Bounds.IntersectsWith(picProjectile1.Bounds) ||
                        picSpaceShip.Bounds.IntersectsWith(picProjectile2.Bounds) ||
                        picSpaceShip.Bounds.IntersectsWith(picProjectile4.Bounds) ||
                        picSpaceShip.Bounds.IntersectsWith(picProjectile5.Bounds) ||
                        picSpaceShip.Bounds.IntersectsWith(picProjectile8.Bounds) ||
                        picSpaceShip.Bounds.IntersectsWith(picProjectile9.Bounds) ||
                        picSpaceShip.Bounds.IntersectsWith(picProjectile11.Bounds))
                    {
                        collisionCheck();//a method that I made to run code in the event of a collision
                    }
                    //checking if images left the form
                    if (picProjectile11.Top > 610)
                    {
                        picProjectile11.Visible = false;//making image invisible
                    }
                    //checking if images left the form
                    if (picProjectile2.Top > 610)
                    {
                        picProjectile2.Visible = false;//making image invisible
                    }
                    //checking if images left the form
                    if (picProjectile1.Top > 610)
                    {
                        picProjectile1.Visible = false;//making image invisible
                    }
                    //checking if images left the form
                    if (picProjectile9.Top > 610)
                    {
                        picProjectile9.Visible = false;//making image invisible
                    }
                    //checking if images left the form
                    if (picProjectile8.Top > 610)
                    {
                        picProjectile8.Visible = false;//making image invisible
                    }
                    //checking if images left the form
                    if (picProjectile4.Top > 610)
                    {
                        //since 4 and 5 have the same projection rate, they should both be inviisble when 4 reaches the end
                        picProjectile4.Visible = false;//making image invisible
                        picProjectile5.Visible = false;//making image invisible
                        //placing all pictureboxes back to initial locations because I am going to the these pictures in the next round
                        picProjectile1.Location = new Point(1, 3);
                        picProjectile5.Location = new Point(293, 3);
                        picProjectile9.Location = new Point(582, 3);
                        picProjectile11.Location = new Point(728, 3);
                        Round++;//advamcing to the round
                    }

                    //making the images visible
                    picProjectile1.Visible = true;
                    picProjectile2.Visible = true;
                    picProjectile4.Visible = true;
                    picProjectile5.Visible = true;
                    picProjectile8.Visible = true;
                    picProjectile9.Visible = true;
                    picProjectile11.Visible = true;
                    //projectile Dispatch
                    picProjectile1.Top += projectileDispatch + 178;
                    picProjectile2.Top += projectileDispatch + 179;
                    picProjectile4.Top += projectileDispatch + 174;
                    picProjectile5.Top += projectileDispatch + 174;
                    picProjectile8.Top += projectileDispatch + 175;
                    picProjectile9.Top += projectileDispatch + 177;
                    picProjectile11.Top += projectileDispatch + 187;
                    //making the other images invisible
                    picProjectile3.Visible = false;
                    picProjectile6.Visible = false;
                    picProjectile7.Visible = false;
                    picProjectile10.Visible = false;
                }
                //checking if the user advanced to the next round
                else if(Round == 3)
                {
                    //checking if SpaceShip collided with the projectiles
                    if (picSpaceShip.Bounds.IntersectsWith(picProjectile1.Bounds) ||
                        picSpaceShip.Bounds.IntersectsWith(picProjectile3.Bounds) ||
                        picSpaceShip.Bounds.IntersectsWith(picProjectile5.Bounds) ||
                        picSpaceShip.Bounds.IntersectsWith(picProjectile7.Bounds) ||
                        picSpaceShip.Bounds.IntersectsWith(picProjectile9.Bounds) ||
                        picSpaceShip.Bounds.IntersectsWith(picProjectile11.Bounds))
                    {
                        collisionCheck();//a method that I made to run code in the event of a collision
                    }

                    //checking if images left the form
                    if (picProjectile11.Top > 610)
                    {
                        picProjectile11.Visible = false;//making image invisible
                    }
                    //checking if images left the form
                    if (picProjectile5.Top > 610)
                    {
                        picProjectile5.Visible = false;//making image invisible
                    }
                    //checking if images left the form
                    if (picProjectile3.Top > 610)
                    {
                        picProjectile3.Visible = false;//making image invisible
                    }
                    //checking if images left the form
                    if (picProjectile1.Top > 610)
                    {
                        picProjectile1.Visible = false;//making image invisible
                    }
                    //checking if images left the form
                    if (picProjectile9.Top > 610)
                    {
                        picProjectile9.Visible = false;//making image invisible
                    }
                    //checking if images left the form
                    if (picProjectile7.Top > 610)
                    {
                        picProjectile7.Visible = false;//making image invisible
                        //placing all pictureboxes back to initial locations because I am going to the these pictures in the next round
                        picProjectile1.Location = new Point(1, 3);
                        picProjectile5.Location = new Point(293, 3);
                        picProjectile9.Location = new Point(582, 3);
                        Round++;//advancing to the next round
                    }

                    //making the images visible
                    picProjectile1.Visible = true;
                    picProjectile3.Visible = true;
                    picProjectile5.Visible = true;
                    picProjectile7.Visible = true;
                    picProjectile9.Visible = true;
                    picProjectile11.Visible = true;
                    //projectile Dispatch
                    picProjectile1.Top += projectileDispatch + 188;
                    picProjectile3.Top += projectileDispatch + 189;
                    picProjectile5.Top += projectileDispatch + 194;
                    picProjectile7.Top += projectileDispatch + 184;
                    picProjectile9.Top += projectileDispatch + 185;
                    picProjectile11.Top += projectileDispatch + 197;
                    //making the other images invisible
                    picProjectile2.Visible = false;
                    picProjectile4.Visible = false;
                    picProjectile6.Visible = false;
                    picProjectile8.Visible = false;
                    picProjectile10.Visible = false;
                }
                //checking if user advanced to Round 4
                else if (Round == 4)
                {
                    //checking if SpaceShip collided with the projectiles
                    if (picSpaceShip.Bounds.IntersectsWith(picProjectile1.Bounds) ||
                        picSpaceShip.Bounds.IntersectsWith(picProjectile2.Bounds) ||
                        picSpaceShip.Bounds.IntersectsWith(picProjectile5.Bounds) ||
                        picSpaceShip.Bounds.IntersectsWith(picProjectile6.Bounds) ||
                        picSpaceShip.Bounds.IntersectsWith(picProjectile9.Bounds) ||
                        picSpaceShip.Bounds.IntersectsWith(picProjectile10.Bounds))
                    {
                        collisionCheck();//a method that I made to run code in the event of a collision
                    }
                    //checking if images left the form
                    if (picProjectile10.Top > 610)
                    {
                        picProjectile10.Visible = false;//making image invisible
                    }
                    //checking if images left the form
                    if (picProjectile5.Top > 610)
                    {
                        picProjectile5.Visible = false;//making image invisible
                    }
                    //checking if images left the form
                    if (picProjectile2.Top > 610)
                    {
                        picProjectile2.Visible = false;//making image invisible
                    }
                    //checking if images left the form
                    if (picProjectile1.Top > 610)
                    {
                        picProjectile1.Visible = false;//making image invisible
                    }
                    //checking if images left the form
                    if (picProjectile9.Top > 610)
                    {
                        picProjectile9.Visible = false;//making image invisible
                    }
                    //checking if images left the form
                    if (picProjectile6.Top > 610)
                    {
                        picProjectile6.Visible = false;//making image invisible
                        Round++;//advancing to the next round
                    }

                    //making the images visible
                    picProjectile1.Visible = true;
                    picProjectile3.Visible = true;
                    picProjectile5.Visible = true;
                    picProjectile7.Visible = true;
                    picProjectile9.Visible = true;
                    picProjectile11.Visible = true;
                    //projectile Dispatch
                    picProjectile1.Top += projectileDispatch + 198;
                    picProjectile2.Top += projectileDispatch + 199;
                    picProjectile5.Top += projectileDispatch + 204;
                    picProjectile6.Top += projectileDispatch + 194;
                    picProjectile9.Top += projectileDispatch + 195;
                    picProjectile10.Top += projectileDispatch + 207;
                    //making the other images invisible
                    picProjectile2.Visible = false;
                    picProjectile4.Visible = false;
                    picProjectile6.Visible = false;
                    picProjectile8.Visible = false;
                    picProjectile10.Visible = false;
                }
                //if user passed Round 4, they won
                else if (Round == 5)
                {
                    gameEndCheck();
 
                }
            }
        }

        private void tmrLabelColourTransition_Tick(object sender, EventArgs e)//timer used to transition between colours
        {
            //.ForeColor sets the foreground color of the control. I learnt this here (https://stackoverflow.com/questions/10441000/how-to-programmatically-set-the-forecolor-of-a-label-to-its-default)
            //.FromArgb produces an 8-bit colour value (Red, Green, and Blue). I lenr this here (https://docs.microsoft.com/en-us/dotnet/api/system.drawing.color.fromargb?view=net-5.0)
            //rnd.Next(0, 255) generates a random number from 0 to 255 using the object rdn from thw class Random
            lblSwiftSalvation.ForeColor = Color.FromArgb(rnd.Next(0, 255), rnd.Next(0, 255), rnd.Next(0, 255), rnd.Next(0, 255));
            btnStart.ForeColor = Color.FromArgb(rnd.Next(0, 255), rnd.Next(0, 255), rnd.Next(0, 255), rnd.Next(0, 255));
        }

        private void btnStart_Click(object sender, EventArgs e)//when the user clicks start, then the timers will go off and the game will start
        {
            tmrMovePic.Enabled = true;//enables the timer that is responsible for moving the Space Ship
            tmrProjectileDispatch.Enabled = true;//enables the timer that is responsible for moving the projectiles
            lblLevel.Visible = true;//renders the label visible to show the level of the game
            lblRound.Visible = true;//renders the label visible to show the Round of the level
            btnStart.Visible = false;//hides the start button
            btnStart.Enabled = false;//disables the start button
            menuStrip.Visible = false;//hides the menu strip that is used to explain what the game is and how it is played
            menuStrip.Enabled = false;//disables the menu strip
            lblSwiftSalvation.Visible = false;//hides the game title label
            Round = 1;//setting Round initially to 1
            level = 1;//setting level initially to 1
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)//this menu strip sub title is primarily focused on helping out the user on the story line of the game
        {
            MessageBox.Show("The Year is 3020, The sun's core is unstable and is scheduled to emit a Supernova in approximately 20 mins." +
                " You, are on a Classified mission to find life signs on Pluto. You must abord the mission and reach the Sun to throw a core stabilizer" +
                " into the sun so that life as we know it will be saved. Dodge floating objects in the galaxy to savor your ship's stability." +
                " If you get hit, you must fix your ship's advanced circuitboard by defeating the AI in a match of Tic Tac Toe (best of 3)\n\n" +
                "By Marwan Ali"
                );
        }

        private void howToPlayToolStripMenuItem_Click(object sender, EventArgs e)//this menu strip sub title is primarily focused on helping out the user on how to play
        {
            MessageBox.Show("use the up, down, left, and right buttons to toggle your spaceship. When you reach to the TicTacToe region, start by clicking any of the 9 boxes");
        }

        private void evntKeyDown(object sender, KeyEventArgs e)//this event is triggered when a key is pressed. I learnt this here(https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.control.keydown?view=net-5.0)
        {
            //e is the parameter inthe event evntKeyDown. Keycode basically returns the code of the pressed key. So when put to gether, e.Keycode, reads the key prssed in the event
            //I learn this here (https://www.dotnetperls.com/keycode)
            if (e.KeyCode == Keys.Left)//then e.Keycode gets compared with keys on the keyboard. I compared it here with the left arrow key
            {
                goLeft = true;//if user pressed left key, the boolean is true
            }
            if (e.KeyCode == Keys.Right)//then e.Keycode gets compared with keys on the keyboard. I compared it here with the right arrow key
            {
                goRight = true;//if user pressed right key, the boolean is true
            }
            if (e.KeyCode == Keys.Down)//then e.Keycode gets compared with keys on the keyboard. I compared it here with the down arrow key
            {
                goDown = true;//if user pressed down key, the boolean is true
            }
            if (e.KeyCode == Keys.Up)//then e.Keycode gets compared with keys on the keyboard. I compared it here with the up arrow key
            {
                goUp = true;//if user pressed up key, the boolean is true
            }
        }

        private void evntKeyUp(object sender, KeyEventArgs e)//this event is triggered when a key is released after being pressed. I learnt this here(https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.control.keyup?view=net-5.0)
        {
            //e is the parameter inthe event evntKeyUp. Keycode basically returns the code of the pressed key. So when put to gether, e.Keycode, reads the key released in the event
            //I learn this here (https://www.dotnetperls.com/keycode)
            if (e.KeyCode == Keys.Left)//then e.Keycode gets compared with keys on the keyboard. I compared it here with the left arrow key
            {
                goLeft = false;//if user released left key, the boolean is false
            }
            if (e.KeyCode == Keys.Right)//then e.Keycode gets compared with keys on the keyboard. I compared it here with the right arrow key
            {
                goRight = false;//if user released right key, the boolean is false
            }
            if (e.KeyCode == Keys.Down)//then e.Keycode gets compared with keys on the keyboard. I compared it here with the down arrow key
            {
                goDown = false;//if user released down key, the boolean is false
            }
            if (e.KeyCode == Keys.Up)//then e.Keycode gets compared with keys on the keyboard. I compared it here with the up arrow key
            {
                goUp = false;//if user released up key, the boolean is false
            }
        }

        private void movePic_Tick(object sender, EventArgs e)//this timer is primarly focused on miving the Space Ship image
        {
            //the goLeft boolean is set true when pressed on in the keyDown event. When pressed on, the space ship will move to the left by subtracting the
            //amount of the dispatch integer variable. I also included that the image's .Left (x-coordinate) should be greater than 0. I said this because I dont 
            //want the Space Ship to travel outside of the form. So when the SpaceShip moves all the way left, there will be a border trapping the image within the form
            if (goLeft == true && picSpaceShip.Left > 0)
            {
                picSpaceShip.Left -= dispatch;//Space Ship Dispatch to the left
            }
            //the goright boolean is set true when pressed on in the keyDown event. When pressed on, the space ship will move to the rightt by accumilating the
            //amount of the dispatch integer variable. I also included that the image's .Left (x-coordinate) should be smaller than 700. I said this because I dont 
            //want the Space Ship to travel outside of the form. So when the SpaceShip moves all the way right, there will be a border trapping the image within the form
            if (goRight == true && picSpaceShip.Left < 700)
            {
                picSpaceShip.Left += dispatch;//Space Ship Dispatch to the right
            }
            //the goDown boolean is set true when pressed on in the keyDown event. When pressed on, the space ship will move downwards by accumilating the
            //amount of the dispatch integer variable. I also included that the image's .Top (y-coordinate) should be smaller than 565. I said this because I dont 
            //want the Space Ship to travel outside of the form. So when the SpaceShip moves all the way down, there will be a border trapping the image within the form
            if (goDown == true && picSpaceShip.Top < 565)
            {
                picSpaceShip.Top += dispatch;//Space Ship Dispatch downwards
            }
            //the goUp boolean is set true when pressed on in the keyDown event. When pressed on, the space ship will move to the Up by subtracting the
            //amount of the dispatch integer variable. I also included that the image's .Top (y-coordinate) should be greater than 0. I said this because I dont 
            //want the Space Ship to travel outside of the form. So when the SpaceShip moves all the way up, there will be a border trapping the image within the form
            if (goUp == true && picSpaceShip.Top > 0)
            {
                picSpaceShip.Top -= dispatch;//Space Ship Dispatch upwards
            }
        }

        private void collisionCheck()//method made for executing code after the user collided with any projectiles
        {
            tmrProjectileDispatch.Enabled = false;//stops the timer than runs the game itself
            this.Hide();//hides the spcInvdrs form. I learnt this here(https://www.techotopia.com/index.php/Hiding_and_Showing_Forms_in_C_Sharp#Hiding_Forms_in_C.23)
            frmTicTacToe frmXO = new frmTicTacToe();//calling the TicTacToe form and placingit in a frmXO. I learnt this for my mom ;).  I really need help, I could fond anything on the web, so she rescued me. Hevent you ever asked your mom for help Grandma??
            frmXO.ShowDialog();//shows the TicTacToe Form
            TextWriter txtProgression = new StreamWriter("progression.txt");//Class that allows the writing of text in a stream
                                                                            //the text within the brackets () is the path to the text file that the TextWriter should type the text in
            txtProgression.Write("You made it to: \nLevel: " + level + "\tRound:" + Round);//typing the progression level and round
                                                                                           //in a seperate Text File
            txtProgression.Close();//closes the TextWriter class parameter txtProgression. .Close() basically hodes the form display and memory. I learnt this here(https://www.techotopia.com/index.php/Hiding_and_Showing_Forms_in_C_Sharp#Hiding_Forms_in_C.23)
        }

        private bool gameEndCheck()
        {
            if (level == 9 && Round == 5)
            {
                tmrProjectileDispatch.Enabled = false;//Ending the game by disabling the timer
                //setting all images and labels invisible so that they know that there are no more projectiles to dodge
                picProjectile1.Visible = false;
                picProjectile2.Visible = false;
                picProjectile3.Visible = false;
                picProjectile4.Visible = false;
                picProjectile5.Visible = false;
                picProjectile6.Visible = false;
                picProjectile7.Visible = false;
                picProjectile8.Visible = false;
                picProjectile9.Visible = false;
                picProjectile10.Visible = false;
                picProjectile11.Visible = false;
                picDiagonalProjectile1.Visible = false;
                picDiagonalProjectile2.Visible = false;
                picDiagonalProjectile3.Visible = false;
                lblLevel.Visible = false;
                lblRound.Visible = false;
                //informs the user that they have won
                MessageBox.Show("You saved the galaxy!! Time to come home HERO!!");
                return true;
            }
            return false;
        }
    }
}
