using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Threading;
using System.Net.Sockets;

namespace national_geographic
{
    public partial class Form1 : Form
    {

        Inventory inven;
        Login login;
        Bitmap status = Properties.Resources.status;
        Bitmap map2 = Properties.Resources.mapx2;
        Bitmap u0 = Properties.Resources.u0;
        Bitmap u1 = Properties.Resources.u1;
        Bitmap u2 = Properties.Resources.u2;
        Bitmap u3 = Properties.Resources.u3;
        Bitmap u4 = Properties.Resources.u4;
        Bitmap ur0 = Properties.Resources.ur0;
        Bitmap ur1 = Properties.Resources.ur1;
        Bitmap ur2 = Properties.Resources.ur2;
        Bitmap ur3 = Properties.Resources.ur3;
        Bitmap ur4 = Properties.Resources.ur4;
        Bitmap ul0 = Properties.Resources.lu0;
        Bitmap ul1 = Properties.Resources.lu1;
        Bitmap ul2 = Properties.Resources.lu2;
        Bitmap ul3 = Properties.Resources.lu3;
        Bitmap ul4 = Properties.Resources.lu4;
        Bitmap d0 = Properties.Resources.d0;
        Bitmap d1 = Properties.Resources.d1;
        Bitmap d2 = Properties.Resources.d2;
        Bitmap d3 = Properties.Resources.d3;
        Bitmap d4 = Properties.Resources.d4;
        Bitmap dl0 = Properties.Resources.dl0;
        Bitmap dl1 = Properties.Resources.dl1;
        Bitmap dl2 = Properties.Resources.dl2;
        Bitmap dl3 = Properties.Resources.dl3;
        Bitmap dl4 = Properties.Resources.dl4;
        Bitmap dr0 = Properties.Resources.rd0;
        Bitmap dr1 = Properties.Resources.rd1;
        Bitmap dr2 = Properties.Resources.rd2;
        Bitmap dr3 = Properties.Resources.rd3;
        Bitmap dr4 = Properties.Resources.rd4;
        Bitmap r0 = Properties.Resources.r0;
        Bitmap r1 = Properties.Resources.r1;
        Bitmap r2 = Properties.Resources.r2;
        Bitmap r3 = Properties.Resources.r3;
        Bitmap r4 = Properties.Resources.r4;
        Bitmap l0 = Properties.Resources.l0;
        Bitmap l1 = Properties.Resources.l1;
        Bitmap l2 = Properties.Resources.l2;
        Bitmap l3 = Properties.Resources.l3;
        Bitmap l4 = Properties.Resources.l4;    
        Bitmap uz0 = Properties.Resources.uz0;
        Bitmap urz0 = Properties.Resources.urz0;
        Bitmap luz0 = Properties.Resources.luz0;
        Bitmap dz0 = Properties.Resources.dz0;
        Bitmap dlz0 = Properties.Resources.dlz0;
        Bitmap rdz0 = Properties.Resources.rdz0;
        Bitmap rz0 = Properties.Resources.rz0;
        Bitmap lz0 = Properties.Resources.lz0;


        Bitmap xu0 = Properties.Resources.xu0;
        Bitmap xu1 = Properties.Resources.xu1;
        Bitmap xu2 = Properties.Resources.xu2;
        Bitmap xu3 = Properties.Resources.xu3;
        Bitmap xu4 = Properties.Resources.xu4;
        Bitmap xur0 = Properties.Resources.xur0;
        Bitmap xur1 = Properties.Resources.xur1;
        Bitmap xur2 = Properties.Resources.xur2;
        Bitmap xur3 = Properties.Resources.xur3;
        Bitmap xur4 = Properties.Resources.xur4;
        Bitmap xul0 = Properties.Resources.xlu0;
        Bitmap xul1 = Properties.Resources.xlu1;
        Bitmap xul2 = Properties.Resources.xlu2;
        Bitmap xul3 = Properties.Resources.xlu3;
        Bitmap xul4 = Properties.Resources.xlu4;
        Bitmap xd0 = Properties.Resources.xd0;
        Bitmap xd1 = Properties.Resources.xd1;
        Bitmap xd2 = Properties.Resources.xd2;
        Bitmap xd3 = Properties.Resources.xd3;
        Bitmap xd4 = Properties.Resources.xd4;
        Bitmap xdl0 = Properties.Resources.xdl0;
        Bitmap xdl1 = Properties.Resources.xdl1;
        Bitmap xdl2 = Properties.Resources.xdl2;
        Bitmap xdl3 = Properties.Resources.xdl3;
        Bitmap xdl4 = Properties.Resources.xdl4;
        Bitmap xdr0 = Properties.Resources.xrd0;
        Bitmap xdr1 = Properties.Resources.xrd1;
        Bitmap xdr2 = Properties.Resources.xrd2;
        Bitmap xdr3 = Properties.Resources.xrd3;
        Bitmap xdr4 = Properties.Resources.xrd4;
        Bitmap xr0 = Properties.Resources.xr0;
        Bitmap xr1 = Properties.Resources.xr1;
        Bitmap xr2 = Properties.Resources.xr2;
        Bitmap xr3 = Properties.Resources.xr3;
        Bitmap xr4 = Properties.Resources.xr4;
        Bitmap xl0 = Properties.Resources.xl0;
        Bitmap xl1 = Properties.Resources.xl1;
        Bitmap xl2 = Properties.Resources.xl2;
        Bitmap xl3 = Properties.Resources.xl3;
        Bitmap xl4 = Properties.Resources.xl4;

        Bitmap xuz0 = Properties.Resources.xuz0;
        Bitmap xurz0 = Properties.Resources.xurz0;
        Bitmap xluz0 = Properties.Resources.xluz0;
        Bitmap xdz0 = Properties.Resources.xdz0;
        Bitmap xdlz0 = Properties.Resources.xdlz0;
        Bitmap xrdz0 = Properties.Resources.xrdz0;
        Bitmap xrz0 = Properties.Resources.xrz0;
        Bitmap xlz0 = Properties.Resources.xlz0;

        Bitmap au0 = Properties.Resources.au0;
        Bitmap alu0 = Properties.Resources.alu0;
        Bitmap aru0 = Properties.Resources.aur0;
        Bitmap ar0 = Properties.Resources.ar0;
        Bitmap al0 = Properties.Resources.al0;
        Bitmap ad0 = Properties.Resources.ad0;
        Bitmap ard0 = Properties.Resources.ard0;
        Bitmap adl0 = Properties.Resources.adl0;


        Bitmap tr1 = Properties.Resources.tree1;
        Bitmap tr2 = Properties.Resources.tree2;
        Bitmap tr3 = Properties.Resources.tree3;
        Bitmap st = Properties.Resources.stone;
        Bitmap wd = Properties.Resources.firewood;
        Bitmap mt = Properties.Resources.meat;
        Bitmap fence0 = Properties.Resources.fence_0;
        Bitmap fence1 = Properties.Resources.fence_1;
        Bitmap fencedoor0 = Properties.Resources.fencedoor;
        Bitmap fencedoor1 = Properties.Resources.fencedoor1;

        Bitmap g_d = Properties.Resources.g_d;
        Bitmap g_dl = Properties.Resources.g_dl;
        Bitmap g_dr = Properties.Resources.g_dr;
        Bitmap g_u = Properties.Resources.g_u;
        Bitmap g_ul = Properties.Resources.g_ul;
        Bitmap g_ur = Properties.Resources.g_ur;
        Bitmap g_r = Properties.Resources.g_r;
        Bitmap g_l = Properties.Resources.g_l;

        Bitmap p_d = Properties.Resources.p_d;
        Bitmap p_dl = Properties.Resources.p_dl;
        Bitmap p_dr = Properties.Resources.p_dr;
        Bitmap p_u = Properties.Resources.p_u;
        Bitmap p_ul = Properties.Resources.p_ul;
        Bitmap p_ur = Properties.Resources.p_ur;
        Bitmap p_r = Properties.Resources.p_r;
        Bitmap p_l = Properties.Resources.p_l;

        Bitmap hfw = Properties.Resources.handfirewood;
        Bitmap hf = Properties.Resources.handfire;
        Bitmap bm10 = Properties.Resources.brightmap10;
        Bitmap bm08 = Properties.Resources.brightmap08;


        int tx, ty;
        int bx, by;
        int mapsizex, mapsizey;
        int i_wood, i_stone, i_meat;
        int fx;
        int fy;
        List<character> chars = new List<character>();
        List<tree> trees = new List<tree>();
        List<wood> woods = new List<wood>();
        List<stone> stones = new List<stone>();
        List<pig> pigs = new List<pig>();
        List<meat> meats = new List<meat>();
        List<fence> fences = new List<fence>();
        List<ghost> ghosts = new List<ghost>();

        class character
        {
            public int x;
            public int y;
            public int width;
            public int height;
            public int weapon;// 0 : 맨손 1 : 도끼 2 : 칼
            public int hungry;
            public int brain;
            public int health;
            public int rx;
            public int ry;
            public Bitmap img;
            public character(int x, int y, int wid, int hei, int w, int hungry, int brain, int health, Bitmap i,int rx,int ry)
            {
                this.x = x;
                this.y = y;
                this.width = wid;
                this.height = hei;
                this.weapon = w;
                this.hungry = hungry;
                this.brain = brain;
                this.health = health;
                this.img = i;
                this.rx = rx;
                this.ry = ry;

            }
            public int attack()
            {
                if (this.weapon == 0)
                    return 10;
                else if (this.weapon == 1)
                    return 20;
                else
                    return 30;

            }
        }
        class pig
        {
            public int x;
            public int y;
            public int width;
            public int height;
            public int health;
            public Bitmap img;
            public pig(int x, int y, int width, int height, int health, Bitmap i)
            {
                this.x = x;
                this.y = y;
                this.width = width;
                this.height = height;
                this.health = health;
                this.img = i;
            }
        }
        class ghost
        {
            public int x;
            public int y;
            public int width;
            public int height;
            public int health;
            public Bitmap img;
            public ghost(int x, int y, int width, int height, int health, Bitmap i)
            {
                this.x = x;
                this.y = y;
                this.width = width;
                this.height = height;
                this.health = health;
                this.img = i;
            }
        }
        class meat
        {
            public int x;
            public int y;
            public int width;
            public int height;
            public Bitmap img;
            public meat(int x, int y, int width, int height, Bitmap i)
            {
                this.x = x;
                this.y = y;
                this.width = width;
                this.height = height;
                this.img = i;
            }
        }
        class tree
        {
            public int x;
            public int y;
            public int width;
            public int height;
            public int health;
            public Bitmap img;
            public tree(int x, int y, int width, int height, int h, Bitmap i)
            {
                this.x = x;
                this.y = y;
                this.width = width;
                this.height = height;
                this.health = h;
                this.img = i;
            }
        }
        class stone
        {
            public int x;
            public int y;
            public int width;
            public int height;
            //public int health; //돌 한번에 줍게 할건지?
            public Bitmap img;
            public stone(int x, int y, int width, int height, Bitmap i)
            {
                this.x = x;
                this.y = y;
                this.width = width;
                this.height = height;
                this.img = i;
            }
        }
        class wood
        {
            public int x;
            public int y;
            public int width;
            public int height;
            //public int health; //돌 한번에 줍게 할건지?
            public Bitmap img;
            public wood(int x, int y, int width, int height, Bitmap i)
            {
                this.x = x;
                this.y = y;
                this.width = width;
                this.height = height;
                this.img = i;
            }
        }
        class fence
        {
            public int x;
            public int y;
            public int width;
            public int height;
            public int health;
            public int fencestate;
            public fence(int x, int y, int width, int height, int health, int f_s)
            {
                this.x = x;
                this.y = y;
                this.width = width;
                this.height = height;
                this.health = health;
                this.fencestate = f_s;
            }
        }
        bool tree_crush(int x1, int y1, int x2, int y2)
        {

            int dx = Math.Abs(x2 - x1);
            int dy = Math.Abs(y2 - y1);
            if (dx < 300 && dy < 200)
                return true;
            else
                return false;

        }
        bool stone_crush(int x1, int y1, int x2, int y2)
        {
            int dx = Math.Abs(x2 - x1);
            int dy = Math.Abs(y2 - y1);
            if (dx < 30 && dy < 30)
                return true;
            else
                return false;
        }
        bool ghost_crush(int x1, int y1, int x2, int y2)
        {
            int dx = Math.Abs(x2 - x1);
            int dy = Math.Abs(y2 - y1);
            if (dx < 30 && dy < 30)
                return true;
            else
                return false;
        }
        bool pig_crush(int x1, int y1, int x2, int y2)
        {
            int dx = Math.Abs(x2 - x1);
            int dy = Math.Abs(y2 - y1);
            if (dx < 50 && dy < 50)
                return true;
            else
                return false;

        }
        bool isInside(character ch,Point[] p)
        {
            //crosses는 점q와 오른쪽 반직선과 다각형과의 교점의 개수
            int crosses = 0;
            for (int i = 0; i < p.Count()-1; i++)
            {
                int j = (i + 1) % p.Count()-1;
                //점 B가 선분 (p[i], p[j])의 y좌표 사이에 있음
                if ((p[i].Y > ch.y) != (p[j].Y > ch.y))
                {
                    //atX는 점 B를 지나는 수평선과 선분 (p[i], p[j])의 교점
                    double atX = (p[j].X - p[i].X) * (ch.y - p[i].Y) / (p[j].Y - p[i].Y) + p[i].X;
                    //atX가 오른쪽 반직선과의 교점이 맞으면 교점의 개수를 증가시킨다.
                    if (ch.x < atX)
                        crosses++;
                }
            }
            return crosses % 2 > 0;
        }
        bool fence_crush(int x1, int y1, int w, int h)
        {
            if (w == 80)
            {
                for (int c = 0; c < chars.Count; c++)
                {
                    if (chars[0].y + chars[0].height - 5 > y1 && y1 + h - 30 > chars[0].y && chars[0].x + 60 < x1 + w && chars[0].x + chars[0].width + 30 > x1)
                        return true;
                }

                for (int i = 0; i < pigs.Count; i++)
                {
                    if (pigs[i].y + pigs[i].height + 10 > y1 && y1 + h - 20 > pigs[i].y && pigs[i].x + 50 < x1 + w && pigs[i].x + pigs[i].width + 30 > x1)
                        return true;
                }

                for (int i = 0; i < trees.Count; i++)
                {
                    if (trees[i].y + trees[i].height + 10 > y1 && y1 + h - 30 > trees[i].y && trees[i].x + 60 < x1 + w && trees[i].x + trees[i].width + 30 > x1)
                        return true;
                }

                for (int i = 0; i < stones.Count; i++)
                {
                    if (stones[i].y + stones[i].height + 15 > y1 && y1 + h - 20 > stones[i].y && stones[i].x + 40 < x1 + w && stones[i].x + stones[i].width + 40 > x1)
                        return true;
                }

                for (int i = 0; i < woods.Count; i++)
                {
                    if (woods[i].y + woods[i].height + 15 > y1 && y1 + h - 20 > woods[i].y && woods[i].x + 40 < x1 + w && woods[i].x + woods[i].width + 40 > x1)
                        return true;
                }

                for (int i = 0; i < meats.Count; i++)
                {
                    if (meats[i].y + meats[i].height + 15 > y1 && y1 + h - 20 > meats[i].y && meats[i].x + 40 < x1 + w && meats[i].x + meats[i].width + 40 > x1)
                        return true;
                }

                for (int i = 0; i < ghosts.Count; i++)
                {
                    if (ghosts[i].y + ghosts[i].height + 15 > y1 && y1 + h - 20 > ghosts[i].y && ghosts[i].x + 40 < x1 + w && ghosts[i].x + ghosts[i].width + 40 > x1)
                        return true;
                }

                for (int i = 0; i < fences.Count; i++)
                {
                    if (fences[i].height == 30)
                    {
                        if (fences[i].y + fences[i].height + 15 > y1 && y1 + h - 20 > fences[i].y && fences[i].x + 40 < x1 + w && fences[i].x + fences[i].width + 40 > x1)
                            return true;
                    }                

                }
            }
            else
            {
                x1 += 25;
                y1 -= 25;
                for (int c = 0; c < chars.Count; c++)
                {
                    if (chars[0].y + chars[0].height - 15 > y1 && y1 + h - 40 > chars[0].y && chars[0].x + 65 < x1 + w && chars[0].x + chars[0].width + 20 > x1)
                        return true;
                }

                for (int i = 0; i < pigs.Count; i++)
                {
                    if (pigs[i].y + pigs[i].height > y1 && y1 + h - 20 > pigs[i].y && pigs[i].x + 50 < x1 + w && pigs[i].x + pigs[i].width + 30 > x1)
                        return true;
                }

                for (int i = 0; i < trees.Count; i++)
                {
                    if (trees[i].y + trees[i].height + 5 > y1 && y1 + h - 30 > trees[i].y && trees[i].x + 60 < x1 + w && trees[i].x + trees[i].width + 30 > x1)
                        return true;
                }

                for (int i = 0; i < stones.Count; i++)
                {
                    if (stones[i].y + stones[i].height + 10 > y1 && y1 + h - 20 > stones[i].y && stones[i].x + 35 < x1 + w && stones[i].x + stones[i].width + 40 > x1)
                        return true;
                }

                for (int i = 0; i < woods.Count; i++)
                {
                    if (woods[i].y + woods[i].height + 10 > y1 && y1 + h - 20 > woods[i].y && woods[i].x + 35 < x1 + w && woods[i].x + woods[i].width + 40 > x1)
                        return true;
                }

                for (int i = 0; i < meats.Count; i++)
                {
                    if (meats[i].y + meats[i].height + 10 > y1 && y1 + h - 20 > meats[i].y && meats[i].x + 35 < x1 + w && meats[i].x + meats[i].width + 40 > x1)
                        return true;
                }

                for (int i = 0; i < ghosts.Count; i++)
                {
                    if (ghosts[i].y + ghosts[i].height + 10 > y1 && y1 + h - 20 > ghosts[i].y && ghosts[i].x + 35 < x1 + w && ghosts[i].x + ghosts[i].width + 40 > x1)
                        return true;
                }

                for (int i = 0; i < fences.Count; i++)
                {                 
                    if (fences[i].height == 80)
                        if (fences[i].y + fences[i].height - 20 > y1 && y1 + h - 45 > fences[i].y && fences[i].x + 60 < x1 + w && fences[i].x + fences[i].width + 20 > x1)
                            return true;
                }

            }
            return false;
        }
        
        public string message = string.Empty;        
        public Form1()
        {            
          //  new Thread(new ThreadStart(move_s)).Start(); //tree 어둡게 할때 오류
            InitializeComponent();
            inven = new Inventory(this);
            inven.Opacity = 0;
            inven.Show();
            Rectangle mapsize = this.ClientRectangle;
            mapsizex = mapsize.Width;
            mapsizey = mapsize.Height;
            tx = mapsizex / 2;
            ty = mapsizey / 2;
            bx = 0;
            by = 0;
            i_wood = 0;
            i_stone = 0;
            i_meat = 0;            
            inven.label1.Text = i_wood.ToString() + " 개";
            inven.label2.Text = i_stone.ToString() + " 개";
            inven.label3.Text = i_meat.ToString() + " 개";

            this.SetStyle(ControlStyles.DoubleBuffer, true); //더블 버퍼링
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            this.SetStyle(ControlStyles.UserPaint, true);

            character myunit = new character(tx, ty, 70, 100, 0, 100, 100, 100, d0, tx, ty);//x,y,width,height,weapon,health,img            

            chars.Add(myunit);


            System.Windows.Forms.Timer timer2 = new System.Windows.Forms.Timer();
            timer2.Interval = 50;
            timer2.Tick += new EventHandler(Timer2_Tick);
            timer2.Start();

            System.Windows.Forms.Timer timer1 = new System.Windows.Forms.Timer();
            timer1.Interval = 4000;//리젠 속도 (나무 자라는 속도, 돌 생기는 속도)//낮과 밤이 바뀌는 속도
            timer1.Tick += new EventHandler(Timer1_Tick);
            timer1.Start();

            System.Windows.Forms.Timer character_state = new System.Windows.Forms.Timer();
            character_state.Interval = 1500;
            character_state.Tick += new EventHandler(character_state_tick);
            character_state.Start();
            
            System.Windows.Forms.Timer attack_timer = new System.Windows.Forms.Timer();
            attack_timer.Interval = 50;
            attack_timer.Tick += new EventHandler(attack_tick);

            System.Windows.Forms.Timer pig_move = new System.Windows.Forms.Timer();
            pig_move.Interval = 10;
            pig_move.Tick += new EventHandler(pig_move_tick);
            pig_move.Start();

            System.Windows.Forms.Timer ghost_move = new System.Windows.Forms.Timer();
            ghost_move.Interval = 10;
            ghost_move.Tick += new EventHandler(ghost_move_tick);
            ghost_move.Start();

        }
        void alltimerstop()
        {
            timer1.Stop();
            timer2.Stop();
            attack_timer.Stop();
            pig_move.Stop();
            ghost_move.Stop();
            
        }
        public static Bitmap ChangeOpacity(Bitmap img, float opacityvalue)

        {

            Bitmap bmp = new Bitmap(img.Width, img.Height); // Determining Width and Height of Source Image

            Graphics graphics = Graphics.FromImage(bmp);

            ColorMatrix colormatrix = new ColorMatrix();

            colormatrix.Matrix33 = opacityvalue;

            ImageAttributes imgAttribute = new ImageAttributes();

            imgAttribute.SetColorMatrix(colormatrix, ColorMatrixFlag.Default, ColorAdjustType.Bitmap);

            graphics.DrawImage(img, new Rectangle(0, 0, bmp.Width, bmp.Height), 0, 0, img.Width, img.Height, GraphicsUnit.Pixel, imgAttribute);

            graphics.Dispose();   // Releasing all resource used by graphics 

            return bmp;

        }
        float mapbright = 1.0f;
        float blood = 0.0f;
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            for (int c = 0; c < chars.Count; c++)
            {
                for (int i = 0; i < trees.Count; i++)
                {
                    if (unit_object_crush(chars[0], trees[i]) && to[i] == false)
                    {
                        to[i] = true;
                        trees[i].img = ChangeOpacity(trees[i].img, 0.6f);
                    }
                    if (!unit_object_crush(chars[0], trees[i]) && to[i] == true)
                    {
                        trees[i].img = ChangeOpacity(trees[i].img, 5 / 3f);
                        to[i] = false;
                    }
                }
            }

            ImageAttributes imt = new ImageAttributes();
            ColorMatrix myColorMatrix = new ColorMatrix();

            myColorMatrix.Matrix00 = mapbright + blood;
            // Green
            myColorMatrix.Matrix11 = mapbright;
            // Blue
            myColorMatrix.Matrix22 = mapbright;

            myColorMatrix.Matrix33 = 1.00f;
            // w
            myColorMatrix.Matrix44 = 1.00f;
            imt.SetColorMatrix(myColorMatrix);


            ImageAttributes fireimt = new ImageAttributes();
            ColorMatrix fireimageColorMatrix = new ColorMatrix();
            fireimageColorMatrix.Matrix00 = 1.00f;
            // Green
            fireimageColorMatrix.Matrix11 = 1.00f;
            // Blue
            fireimageColorMatrix.Matrix22 = 1.00f;
            // alpha
            fireimageColorMatrix.Matrix33 = 1.00f;
            // w
            fireimageColorMatrix.Matrix44 = 1.00f;

            fireimt.SetColorMatrix(fireimageColorMatrix);

            ImageAttributes fireimt1 = new ImageAttributes();
            ColorMatrix fireimageColorMatrix1 = new ColorMatrix();
            fireimageColorMatrix1.Matrix00 = 0.80f;
            // Green
            fireimageColorMatrix1.Matrix11 = 0.80f;
            // Blue
            fireimageColorMatrix1.Matrix22 = 0.80f;
            // alpha
            fireimageColorMatrix1.Matrix33 = 1.00f;
            // w
            fireimageColorMatrix1.Matrix44 = 1.00f;

            fireimt1.SetColorMatrix(fireimageColorMatrix1);

            Rectangle rect = new Rectangle(bx, by, 2648, 2200);



            e.Graphics.DrawImage(map2, rect, 0, 0, 2648, 2200, GraphicsUnit.Pixel, imt);


            if (fireon && mapbright < 0.8f)
            {
                e.Graphics.DrawImage(bm08, new Rectangle(fx - 45, fy - 45, 200, 200), 0, 0, 200, 200, GraphicsUnit.Pixel, fireimt1);//brightmap을 원형으로 잘라서 넣기         
                //e.Graphics.DrawImage(bm, new Rectangle(fx - 10, fy - 10, 130, 130), 0, 0, 100, 100, GraphicsUnit.Pixel, fireimt);//brightmap을 원형으로 잘라서 넣기       
            }
            if (fireon && mapbright != 1.0f)
            {
                //e.Graphics.DrawImage(bm, new Rectangle(fx - 45, fy - 45, 200, 200), 0, 0, 100, 100, GraphicsUnit.Pixel, fireimt1);//brightmap을 원형으로 잘라서 넣기         
                e.Graphics.DrawImage(bm10, new Rectangle(fx - 10, fy - 10, 130, 130), 0, 0, 130, 130, GraphicsUnit.Pixel, fireimt);//brightmap을 원형으로 잘라서 넣기       
            }

            Pen p = new Pen(Color.Black);
            for (int i = 0; i < stones.Count; i++)
            {
                if (fire_bright_crush(fx, fy, stones[i].x, stones[i].y + 15) && fireon)
                    e.Graphics.DrawImage(stones[i].img, new Rectangle(stones[i].x, stones[i].y, stones[i].width, stones[i].height), 0, 0, stones[i].width, stones[i].height, GraphicsUnit.Pixel, fireimt);
                else
                    e.Graphics.DrawImage(stones[i].img, new Rectangle(stones[i].x, stones[i].y, stones[i].width, stones[i].height), 0, 0, stones[i].width, stones[i].height, GraphicsUnit.Pixel, imt);
            }
            for (int i = 0; i < woods.Count; i++)
            {
                if (fire_bright_crush(fx, fy, woods[i].x, woods[i].y + 15) && fireon)
                    e.Graphics.DrawImage(woods[i].img, new Rectangle(woods[i].x, woods[i].y, woods[i].width, woods[i].height), 0, 0, woods[i].width, woods[i].height, GraphicsUnit.Pixel, fireimt);
                else
                    e.Graphics.DrawImage(woods[i].img, new Rectangle(woods[i].x, woods[i].y, woods[i].width, woods[i].height), 0, 0, woods[i].width, woods[i].height, GraphicsUnit.Pixel, imt);
            }
            for (int i = 0; i < pigs.Count; i++)
            {
                if (fire_bright_crush(fx, fy, pigs[i].x, pigs[i].y + 25) && fireon)
                    e.Graphics.DrawImage(pigs[i].img, new Rectangle(pigs[i].x, pigs[i].y, pigs[i].width, pigs[i].height), 0, 0, pigs[i].width, pigs[i].height, GraphicsUnit.Pixel, fireimt);
                else
                    e.Graphics.DrawImage(pigs[i].img, new Rectangle(pigs[i].x, pigs[i].y, pigs[i].width, pigs[i].height), 0, 0, pigs[i].width, pigs[i].height, GraphicsUnit.Pixel, imt);
            }
            for (int i = 0; i < ghosts.Count; i++)
            {
                if (fire_bright_crush(fx, fy, ghosts[i].x, ghosts[i].y + 25) && fireon)
                    e.Graphics.DrawImage(ghosts[i].img, new Rectangle(ghosts[i].x, ghosts[i].y, ghosts[i].width, ghosts[i].height), 0, 0, ghosts[i].width, ghosts[i].height, GraphicsUnit.Pixel, fireimt);
                else
                    e.Graphics.DrawImage(ghosts[i].img, new Rectangle(ghosts[i].x, ghosts[i].y, ghosts[i].width, ghosts[i].height), 0, 0, ghosts[i].width, ghosts[i].height, GraphicsUnit.Pixel, imt);
            }
            for (int i = 0; i < meats.Count; i++)
            {
                if (fire_bright_crush(fx, fy, meats[i].x, meats[i].y + 15) && fireon)
                    e.Graphics.DrawImage(meats[i].img, new Rectangle(meats[i].x, meats[i].y, meats[i].width, meats[i].height), 0, 0, meats[i].width, meats[i].height, GraphicsUnit.Pixel, fireimt);
                else
                    e.Graphics.DrawImage(meats[i].img, new Rectangle(meats[i].x, meats[i].y, meats[i].width, meats[i].height), 0, 0, meats[i].width, meats[i].height, GraphicsUnit.Pixel, imt);
            }
            for (int c = 0; c < chars.Count; c++)
            {
                if (fire_bright_crush(fx, fy, chars[0].x, chars[0].y + 50) && fireon)
                    e.Graphics.DrawImage(chars[0].img, new Rectangle(chars[0].x, chars[0].y, chars[0].width, chars[0].height), 0, 0, 70, 100, GraphicsUnit.Pixel, fireimt);
                else
                    e.Graphics.DrawImage(chars[0].img, new Rectangle(chars[0].x, chars[0].y, chars[0].width, chars[0].height), 0, 0, 70, 100, GraphicsUnit.Pixel, imt);
            }
            for (int i = 0; i < trees.Count; i++)
            {
                if (fire_bright_crush(fx, fy, trees[i].x, trees[i].y + 150) && fireon)
                    e.Graphics.DrawImage(trees[i].img, new Rectangle(trees[i].x, trees[i].y, trees[i].width, trees[i].height), 0, 0, trees[i].width, trees[i].height, GraphicsUnit.Pixel, fireimt);
                else
                    e.Graphics.DrawImage(trees[i].img, new Rectangle(trees[i].x, trees[i].y, trees[i].width, trees[i].height), 0, 0, trees[i].width, trees[i].height, GraphicsUnit.Pixel, imt);
            }

            if (fireon)
                e.Graphics.DrawImage(hf, new Rectangle(fx, fy, 100, 100), 0, 0, 100, 100, GraphicsUnit.Pixel, fireimt);


            for (int i = 0; i < fences.Count; i++)
            {
                if (fences[i].fencestate == 0)
                    e.Graphics.DrawImage(fence0, new Rectangle(fences[i].x, fences[i].y, fences[i].width, fences[i].height), 0, 0, fences[i].width, fences[i].height, GraphicsUnit.Pixel, imt);
                else if (fences[i].fencestate == 1)
                    e.Graphics.DrawImage(fence1, new Rectangle(fences[i].x, fences[i].y, fences[i].width, fences[i].height), 0, 0, fences[i].width, fences[i].height, GraphicsUnit.Pixel, imt);
                else if (fences[i].fencestate == 2 && !fencedooropen)
                    e.Graphics.DrawImage(fencedoor0, new Rectangle(fences[i].x, fences[i].y, fences[i].width, fences[i].height), 0, 0, fences[i].width, fences[i].height, GraphicsUnit.Pixel, imt);
                else if (fences[i].fencestate == 2 && fencedooropen)
                    e.Graphics.DrawImage(fencedoor1, new Rectangle(fences[i].x, fences[i].y, fences[i].height, fences[i].width), 0, 0, fences[i].height, fences[i].width, GraphicsUnit.Pixel, imt);
            }

            if (fencecheck1)
            {
                e.Graphics.DrawImage(ChangeOpacity(fence0, 0.6f), new Rectangle(f1x, f1y, 80, 30), 0, 0, 80, 30, GraphicsUnit.Pixel, imt);
            }

            if (fencecheck2)
            {
                e.Graphics.DrawImage(ChangeOpacity(fence1, 0.6f), new Rectangle(f2x, f2y, 30, 80), 0, 0, 30, 80, GraphicsUnit.Pixel, imt);
            }
            if (fencecheck3)
            {
                e.Graphics.DrawImage(ChangeOpacity(fencedoor0, 0.6f), new Rectangle(f3x, f3y, 80, 30), 0, 0, 80, 30, GraphicsUnit.Pixel, imt);
            }
            //if(p3.Count()>0)
            //    e.Graphics.DrawImage(map2, p3);
            //Pen pol = new Pen(Color.Red, 3);
            //if (p3[0].X != 0)
            //    e.Graphics.DrawPolygon(pol, p3);
            
            //for(int c=0;c<chars.Count;c++)
            //{
            //    if (cn_PnPoly(chars[0], p3) == 1)
            //    {
            //        inhomechnum = c;
            //        inhome = true;
            //    }
            //    else
            //        inhome = false;
            //}
        }
        int inhomechnum=-1;
        bool inhome = false;
        Point[] p3;
        bool fire_bright_crush(int fx, int fy, int x, int y)
        {
            int dx = fx + 50 - x;
            int dy = fy + 50 - y;
            double d = Math.Sqrt((double)dx * dx + dy * dy);
            if (d < 100)
                return true;
            else
                return false;
        }
        int cn_PnPoly(character ch, Point[] P)
        {
            int cn = 0;
            for (int i = 0; i < P.Count(); i++)
            {
                int jk = i + 1;
                jk = jk % (P.Count());
                if (((P[i].Y <= ch.y) && (P[jk].Y > ch.y))
                 || ((P[i].Y > ch.y) && (P[jk].Y <= ch.y)))
                {
                    float vt = (float)(ch.y - P[i].Y) / (P[jk].Y - P[i].Y);
                    if (ch.x < P[i].X + vt * (P[jk].X - P[i].X))
                        ++cn;
                }
            }
            return (cn & 1);
        }

        static int ur_on = 0, ul_on = 0, uu_on = 0, ud_on = 0;   //----키보드 눌림저장 스위치 변수
    
        int move_state = 0;       

        private void Timer2_Tick(object sender, EventArgs e)
        {
            for (int c = 0; c < chars.Count; c++)
            {
                for (int s = 0; s < fences.Count; s++)
                {
                    if (fences[s].fencestate != 1)//가로
                    {
                        if (chars[0].y + chars[0].height - 25 > fences[s].y && fences[s].y + fences[s].height - 15 > chars[0].y && chars[0].x + 20 < fences[s].x + fences[s].width && chars[0].x + chars[0].width - 10 > fences[s].x)
                        {
                            ur_on = 0;
                            br_on = 0;      
                            if(ul_on==1&&chars[0].weapon==0)
                            {                                
                                chars[0].img = l0;
                                chars[0].x--;
                            }
                            else if(ul_on == 1 && chars[0].weapon == 1)
                            {
                                chars[0].img = xl0;
                                chars[0].x--;
                            }
                        }
                    }
                    else
                    {
                        if (chars[0].y + chars[0].height - 20 > fences[s].y && fences[s].y + fences[s].height - 20 > chars[0].y && chars[0].x + 65 < fences[s].x + fences[s].width && chars[0].x - 40 + chars[0].width + 20 > fences[s].x)
                        {
                            ur_on = 0;
                            br_on = 0;
                            if (ul_on == 1 && chars[0].weapon == 0)
                            {
                                chars[0].img = l0;
                                chars[0].x-=10;
                            }
                            else if (ul_on == 1 && chars[0].weapon == 1)
                            {
                                chars[0].img = xl0;
                                chars[0].x-=10;
                            }
                        }

                    }
                }
                for (int s = 0; s < fences.Count; s++)
                {
                    if (fences[s].fencestate != 1)//가로
                    {
                        if (chars[0].y + chars[0].height - 25 > fences[s].y && fences[s].y + fences[s].height - 15 > chars[0].y && chars[0].x + 10 < fences[s].x + fences[s].width && chars[0].x + chars[0].width - 10 > fences[s].x)
                        {
                            ul_on = 0;
                            bl_on = 0;                      
                        }        
                    }
                    else
                    {
                        if (chars[0].y + chars[0].height - 30 > fences[s].y && fences[s].y + fences[s].height - 30 > chars[0].y && chars[0].x + 20 < fences[s].x + fences[s].width && chars[0].x - 40 + chars[0].width + 20 > fences[s].x)
                        {
                            ul_on = 0;
                            bl_on = 0;
                        }
                
                    }

                }
                for (int s = 0; s < fences.Count; s++)
                {
                    if (fences[s].fencestate != 1)//가로
                    {
                        if (chars[0].y + chars[0].height - 25 > fences[s].y && fences[s].y + fences[s].height - 15 > chars[0].y && chars[0].x < fences[s].x + fences[s].width - 10 && chars[0].x + chars[0].width - 10 > fences[s].x)
                        {//
                            uu_on = 0;
                            bu_on = 0;
                            if (ud_on == 1 && chars[0].weapon == 0)
                            {
                                chars[0].img = d0;
                                chars[0].y+=10;
                            }
                            else if (ud_on == 1 && chars[0].weapon == 1)
                            {
                                chars[0].img = xd0;
                                chars[0].y+=10;
                            }
                        }
                    }
                    else
                    {
                        if (chars[0].y + chars[0].height - 30 > fences[s].y && fences[s].y + fences[s].height - 20 > chars[0].y && chars[0].x + 20 < fences[s].x + fences[s].width && chars[0].x - 40 + chars[0].width + 20 > fences[s].x)
                        {

                            uu_on = 0;
                            bu_on = 0;
                            if (ud_on == 1 && chars[0].weapon == 0)
                            {
                                chars[0].img = d0;
                                chars[0].y += 10;
                            }
                            else if (ud_on == 1 && chars[0].weapon == 1)
                            {
                                chars[0].img = xd0;
                                chars[0].y += 10;
                            }
                        }

                    }
                }

                for (int s = 0; s < fences.Count; s++)
                {
                    if (fences[s].fencestate != 1)//가로
                    {
                        if (chars[0].y + chars[0].height - 25 > fences[s].y && fences[s].y + fences[s].height - 15 > chars[0].y && chars[0].x < fences[s].x + fences[s].width - 10 && chars[0].x + chars[0].width - 10 > fences[s].x)
                        {//
                            ud_on = 0;
                            bd_on = 0;
                            if (uu_on == 1 && chars[0].weapon == 0)
                            {
                                chars[0].img = u0;
                                chars[0].y -= 10;
                            }
                            else if (uu_on == 1 && chars[0].weapon == 1)
                            {
                                chars[0].img = xu0;
                                chars[0].y -= 10;
                            }
                        }
                    }
                    else
                    {
                        if (chars[0].y + chars[0].height - 30 > fences[s].y && fences[s].y + fences[s].height - 20 > chars[0].y && chars[0].x + 20 < fences[s].x + fences[s].width && chars[0].x - 40 + chars[0].width + 20 > fences[s].x)
                        {

                            ud_on = 0;
                            bd_on = 0;
                            if (uu_on == 1 && chars[0].weapon == 0)
                            {
                                chars[0].img = u0;
                                chars[0].y -= 10;
                            }
                            else if (uu_on == 1 && chars[0].weapon == 1)
                            {
                                chars[0].img = xu0;
                                chars[0].y -= 10;
                            }
                        }
                    }
                }
            }
            fx = chars[0].x;
            fy = chars[0].y;
            move_state++;
            if (move_state == 5)
                move_state = 0;
          
                if (chars[0].weapon == 0)
                {
                    if (ur_on == 1)
                    {
                        if (uu_on == 1)
                        {
                            switch (move_state)
                            {
                                case 0:
                                    chars[0].img = ur0;
                                    break;
                                case 1:
                                    chars[0].img = ur1;
                                    break;
                                case 2:
                                    chars[0].img = ur2;
                                    break;
                                case 3:
                                    chars[0].img = ur3;
                                    break;
                                case 4:
                                    chars[0].img = ur4;
                                    break;
                            }
                        }
                        else if (ud_on == 1)
                            switch (move_state)
                            {
                                case 0:
                                    chars[0].img = dr0;
                                    break;
                                case 1:
                                    chars[0].img = dr1;
                                    break;
                                case 2:
                                    chars[0].img = dr2;
                                    break;
                                case 3:
                                    chars[0].img = dr3;
                                    break;
                                case 4:
                                    chars[0].img = dr4;
                                    break;
                            }
                        else
                        {
                            switch (move_state)
                            {
                                case 0:
                                    chars[0].img = r0;
                                    break;
                                case 1:
                                    chars[0].img = r1;
                                    break;
                                case 2:
                                    chars[0].img = r2;
                                    break;
                                case 3:
                                    chars[0].img = r3;
                                    break;
                                case 4:
                                    chars[0].img = r4;
                                    break;
                            }
                        }
                    }
                    if (ul_on == 1)
                    {
                        if (uu_on == 1)
                        {
                            switch (move_state)
                            {
                                case 0:
                                    chars[0].img = ul0;
                                    break;
                                case 1:
                                    chars[0].img = ul1;
                                    break;
                                case 2:
                                    chars[0].img = ul2;
                                    break;
                                case 3:
                                    chars[0].img = ul3;
                                    break;
                                case 4:
                                    chars[0].img = ul4;
                                    break;
                            }
                        }
                        else if (ud_on == 1)
                        {
                            switch (move_state)
                            {
                                case 0:
                                    chars[0].img = dl0;
                                    break;
                                case 1:
                                    chars[0].img = dl1;
                                    break;
                                case 2:
                                    chars[0].img = dl2;
                                    break;
                                case 3:
                                    chars[0].img = dl3;
                                    break;
                                case 4:
                                    chars[0].img = dl4;
                                    break;
                            }
                        }
                        else
                        {
                            switch (move_state)
                            {
                                case 0:
                                    chars[0].img = l0;
                                    break;
                                case 1:
                                    chars[0].img = l1;
                                    break;
                                case 2:
                                    chars[0].img = l2;
                                    break;
                                case 3:
                                    chars[0].img = l3;
                                    break;
                                case 4:
                                    chars[0].img = l4;
                                    break;
                            }

                        }
                    }
                    if (ud_on == 1 && ur_on == 0 && ul_on == 0)
                    {
                        switch (move_state)
                        {
                            case 0:
                                chars[0].img = d0;
                                break;
                            case 1:
                                chars[0].img = d1;
                                break;
                            case 2:
                                chars[0].img = d2;
                                break;
                            case 3:
                                chars[0].img = d3;
                                break;
                            case 4:
                                chars[0].img = d4;
                                break;
                        }
                    }

                    if (uu_on == 1 && ur_on == 0 && ul_on == 0)
                    {

                        switch (move_state)
                        {
                            case 0:
                                chars[0].img = u0;
                                break;
                            case 1:
                                chars[0].img = u1;
                                break;
                            case 2:
                                chars[0].img = u2;
                                break;
                            case 3:
                                chars[0].img = u3;
                                break;
                            case 4:
                                chars[0].img = u4;
                                break;
                        }
                    }
                }

                else if (chars[0].weapon == 1)
                {
                    if (ur_on == 1)
                    {
                        if (uu_on == 1)
                        {
                            switch (move_state)
                            {
                                case 0:
                                    chars[0].img = xur0;
                                    break;
                                case 1:
                                    chars[0].img = xur1;
                                    break;
                                case 2:
                                    chars[0].img = xur2;
                                    break;
                                case 3:
                                    chars[0].img = xur3;
                                    break;
                                case 4:
                                    chars[0].img = xur4;
                                    break;
                            }
                        }
                        else if (ud_on == 1)
                            switch (move_state)
                            {
                                case 0:
                                    chars[0].img = xdr0;
                                    break;
                                case 1:
                                    chars[0].img = xdr1;
                                    break;
                                case 2:
                                    chars[0].img = xdr2;
                                    break;
                                case 3:
                                    chars[0].img = xdr3;
                                    break;
                                case 4:
                                    chars[0].img = xdr4;
                                    break;
                            }
                        else
                        {
                            switch (move_state)
                            {
                                case 0:
                                    chars[0].img = xr0;
                                    break;
                                case 1:
                                    chars[0].img = xr1;
                                    break;
                                case 2:
                                    chars[0].img = xr2;
                                    break;
                                case 3:
                                    chars[0].img = xr3;
                                    break;
                                case 4:
                                    chars[0].img = xr4;
                                    break;
                            }
                        }
                    }
                    if (ul_on == 1)
                    {

                        if (uu_on == 1)
                        {
                            switch (move_state)
                            {
                                case 0:
                                    chars[0].img = xul0;
                                    break;
                                case 1:
                                    chars[0].img = xul1;
                                    break;
                                case 2:
                                    chars[0].img = xul2;
                                    break;
                                case 3:
                                    chars[0].img = xul3;
                                    break;
                                case 4:
                                    chars[0].img = xul4;
                                    break;
                            }
                        }
                        else if (ud_on == 1)
                        {
                            switch (move_state)
                            {
                                case 0:
                                    chars[0].img = xdl0;
                                    break;
                                case 1:
                                    chars[0].img = xdl1;
                                    break;
                                case 2:
                                    chars[0].img = xdl2;
                                    break;
                                case 3:
                                    chars[0].img = xdl3;
                                    break;
                                case 4:
                                    chars[0].img = xdl4;
                                    break;
                            }
                        }
                        else
                        {
                            switch (move_state)
                            {
                                case 0:
                                    chars[0].img = xl0;
                                    break;
                                case 1:
                                    chars[0].img = xl1;
                                    break;
                                case 2:
                                    chars[0].img = xl2;
                                    break;
                                case 3:
                                    chars[0].img = xl3;
                                    break;
                                case 4:
                                    chars[0].img = xl4;
                                    break;
                            }
                        }
                    }
                    if (ud_on == 1 && ur_on == 0 && ul_on == 0)
                    {

                        switch (move_state)
                        {
                            case 0:
                                chars[0].img = xd0;
                                break;
                            case 1:
                                chars[0].img = xd1;
                                break;
                            case 2:
                                chars[0].img = xd2;
                                break;
                            case 3:
                                chars[0].img = xd3;
                                break;
                            case 4:
                                chars[0].img = xd4;
                                break;
                        }
                    }

                    if (uu_on == 1 && ur_on == 0 && ul_on == 0)
                    {

                        switch (move_state)
                        {
                            case 0:
                                chars[0].img = xu0;
                                break;
                            case 1:
                                chars[0].img = xu1;
                                break;
                            case 2:
                                chars[0].img = xu2;
                                break;
                            case 3:
                                chars[0].img = xu3;
                                break;
                            case 4:
                                chars[0].img = xu4;
                                break;
                        }
                    }
                }
                //배경 및 오브젝트 움직이기
                if (br_on == 1 && bx > -600 && chars[0].x > mapsizex / 2)
                {                    
                    bx -= 10;
                    for (int i = 0; i < trees.Count; i++)
                    {
                        trees[i].x -= 10;
                    }
                    for (int i = 0; i < stones.Count; i++)
                    {
                        stones[i].x -= 10;
                    }
                    for (int i = 0; i < woods.Count; i++)
                    {
                        woods[i].x -= 10;
                    }
                    for (int i = 0; i < pigs.Count; i++)
                    {
                        pigs[i].x -= 10;
                    }
                    for (int i = 0; i < meats.Count; i++)
                    {
                        meats[i].x -= 10;
                    }
                    for (int i = 0; i < fences.Count; i++)
                    {
                        fences[i].x -= 10;
                    }
                    for (int i = 0; i < ghosts.Count; i++)
                    {
                        ghosts[i].x -= 10;
                    }                

                }
                //유닛 움직이기
                else if (ur_on == 1 && chars[0].x < mapsizex - 30)
                {
                    chars[0].x += speed * 10;
                    fx += 10;
                }
     
                //배경 및 오브젝트 움직이기
                if (bl_on == 1 && bx < 0 && chars[0].x < mapsizex / 2)
                {                    
                    bx += 10;

                    for (int i = 0; i < trees.Count; i++)
                    {
                        trees[i].x += 10;
                    }
                    for (int i = 0; i < stones.Count; i++)
                    {
                        stones[i].x += 10;
                    }
                    for (int i = 0; i < woods.Count; i++)
                    {
                        woods[i].x += 10;
                    }
                    for (int i = 0; i < pigs.Count; i++)
                    {
                        pigs[i].x += 10;
                    }
                    for (int i = 0; i < meats.Count; i++)
                    {
                        meats[i].x += 10;
                    }
                    for (int i = 0; i < fences.Count; i++)
                    {
                        fences[i].x += 10;
                    }
                    for (int i = 0; i < ghosts.Count; i++)
                    {
                        ghosts[i].x += 10;
                    }    
                }
                //유닛 움직이기
                else if (ul_on == 1 && chars[0].x > 0)
                {
                    chars[0].x -= speed * 10;
                    
                    fx -= 10;
                }
                //배경 및 오브젝트 움직이기
                if (bu_on == 1 && by < 0 && chars[0].y < mapsizey / 2)
                {
                    
                    by += 10;

                    for (int i = 0; i < trees.Count; i++)
                    {
                        trees[i].y += 10;
                    }
                    for (int i = 0; i < stones.Count; i++)
                    {
                        stones[i].y += 10;
                    }
                    for (int i = 0; i < woods.Count; i++)
                    {
                        woods[i].y += 10;
                    }
                    for (int i = 0; i < pigs.Count; i++)
                    {
                        pigs[i].y += 10;
                    }
                    for (int i = 0; i < meats.Count; i++)
                    {
                        meats[i].y += 10;

                    }
                    for (int i = 0; i < fences.Count; i++)
                    {
                        fences[i].y += 10;
                    }
                    for (int i = 0; i < ghosts.Count; i++)
                    {
                        ghosts[i].y += 10;
                    }        

                }
                //유닛 움직이기
                else if (uu_on == 1 && chars[0].y > 0)
                {
                    chars[0].y -= speed * 10;
                                   
                    fy -= 10;
                }
     
                //배경 및 오브젝트 움직이기
                if (bd_on == 1 && by > -600 && chars[0].y > mapsizey / 2)
                {                    
                    by -= 10;

                    for (int i = 0; i < trees.Count; i++)
                    {
                        trees[i].y -= 10;
                    }
                    for (int i = 0; i < stones.Count; i++)
                    {
                        stones[i].y -= 10;
                    }
                    for (int i = 0; i < woods.Count; i++)
                    {
                        woods[i].y -= 10;
                    }
                    for (int i = 0; i < pigs.Count; i++)
                    {
                        pigs[i].y -= 10;
                    }
                    for (int i = 0; i < meats.Count; i++)
                    {
                        meats[i].y -= 10;
                    }
                    for (int i = 0; i < fences.Count; i++)
                    {
                        fences[i].y -= 10;
                    }
                    for (int i = 0; i < ghosts.Count; i++)
                    {
                        ghosts[i].y -= 10;
                    }    
                }
                //유닛 움직이기
                else if (ud_on == 1 && chars[0].y < mapsizey - 50)
                {
                    chars[0].y += speed * 10;                    
                    fy += 10;
                }
            if (mapbright > 1.000f)
                d_n = true;
            else if (mapbright < 0.200f)
                d_n = false;
            if (d_n)
                mapbright -= 0.002f;
            else
                mapbright += 0.002f;
            Invalidate();
        }
        
        bool die = false;   
        void end_game()
        {
            if (die)
            {
                MessageBox.Show("사망하였습니다.");
                die = false;
            }
        }
        int h_inter = 0;
        private void character_state_tick(object sender, EventArgs e)
        {
            h_inter++;

            if (h_inter == 3)
                h_inter = 0;
            if (inhome)
            {
                chars[inhomechnum].health++;
                MessageBox.Show("집안이라 체력이 증가합니다.");
            }
            for (int c = 0; c < chars.Count; c++)
            {
                //if (isInside(chars[0], p3))
                //{
                //    MessageBox.Show("집안이라 체력이 증가합니다.");
                //    chars[0].health++;
                //}
                label4.Text = chars[0].hungry.ToString();
                label5.Text = chars[0].brain.ToString();
                label6.Text = chars[0].health.ToString();
                if(chars[0].health==0)
                {
                    alltimerstop();
                    chararcter_state.Stop();
                    die = true;
                    end_game();
                    chars[0].health = -10;
                    this.Close();
                }
                if (chars[0].hungry > 0&&h_inter==1)
                    chars[0].hungry--;
                if (chars[0].hungry < 50 && chars[0].health > 0)
                    chars[0].health--;           
                else if (chars[0].health < 100)
                    chars[0].health++;
                if (mapbright < 0.6f&&chars[0].brain>0)
                    chars[0].brain--;//밸런스 수정 필요
            }           
        }

        bool[] to = new bool[10] { false, false, false, false, false, false, false, false, false, false };
        bool d_n = true;
        private void Timer1_Tick(object sender, EventArgs e)
        {
            
            Random r = new Random();
            int stonex, stoney;
            if(stones.Count<10)
            {
                bool chk = true;
                //
                stonex = r.Next(2048-30);
                stoney = r.Next(30,1400);
                
                for (int j = 0; j < stones.Count; j++)
                {
                    if (stone_crush(stonex, stoney, stones[j].x, stones[j].y))
                    {
                        chk = false; break;
                    }
                }
                if (chk == true)
                {                 
                        stones.Add(new stone(stonex, stoney, 30, 30, st));
                }
            }
            int animx, animy;
            if(pigs.Count<10)
            {
                bool chk = true;
                animx = r.Next(2048-50);
                animy = r.Next(30, 1400);
                for (int j = 0; j < pigs.Count; j++)
                {
                    if (pig_crush(animx, animy, pigs[j].x, pigs[j].y))
                    {
                        chk = false; break;
                    }
                }
                if (chk == true)
                {                    
                    pigs.Add(new pig(animx, animy, 50, 50, 50, p_d));
                }
            }
            int ghostx, ghosty;
            if (ghosts.Count < 10)
            {
                bool chk = true;
                ghostx = r.Next(2048-30);
                ghosty = r.Next(30, 1400);
                for (int j = 0; j < ghosts.Count; j++)
                {
                    if (ghost_crush(ghostx, ghosty, ghosts[j].x, ghosts[j].y))
                    {
                        chk = false; break;
                    }
                }
                if (chk == true)
                {                  
                     ghosts.Add(new ghost(ghostx, ghosty, 30, 30, 50, g_d));
                }
            }
            int treex, treey;
            if (trees.Count < 10)
            {
                bool chk = true;
                treex = r.Next(2048-150);
                treey = r.Next(100, 1200);
                for (int j = 0; j < trees.Count; j++)
                {
                    if (tree_crush(treex, treey, trees[j].x, trees[j].y))
                    {
                        chk = false; break;
                    }

                    for (int s = 0; s < fences.Count; s++)
                    {
                        if (fences[s].fencestate == 1)
                        {
                            if (treey + trees[0].height + 5 > fences[s].y - 25 && fences[s].y - 25 + fences[s].height - 30 > treey && treex + 60 < fences[s].x + fences[s].height && treex + trees[0].width + 30 > fences[s].x)
                                chk = false; break;
                        }
                        else
                        { 
                            if (treey + trees[0].height + 10 > fences[s].y && fences[s].y + fences[s].height - 30 > trees[0].y && trees[0].x + 60 < fences[s].x + fences[s].width && trees[0].x + trees[0].width + 30 > fences[s].x)
                                chk = false; break;
                        }
                    }
                }
                if (chk == true)
                {               
                        trees.Add(new tree(treex, treey, 36, 38, 100, tr1));
                }
            }           
            
            for (int i = 0; i < trees.Count; i++)
                if (trees[i].width<=36)
                {
                    trees[i].img = tr2;
                    trees[i].x -= 32;       //나무 뿌리 위치 고정
                    trees[i].y -= 112;
                    trees[i].width = 100;   //나무 사이즈 변경
                    trees[i].height = 150;
                }
                else if (trees[i].width==100)
                {
                    trees[i].img = tr3;
                    trees[i].x -= 25;    //나무 뿌리 위치고정
                    trees[i].y -= 50;
                    trees[i].width = 150;   //나무 사이즈 변경
                    trees[i].height = 200;
                }            
            


            //낮->밤
               
            for(int i=0;i<5;i++)
            {
                gx[i] = r.Next(-1, 2);
                gy[i] = r.Next(-1, 2);
            }
            for (int i = 0; i < 5; i++)
            {
                px[i] = r.Next(-1, 2);
                py[i] = r.Next(-1, 2);
            }
            Invalidate();
        }


        
        bool weapon_tree_crush(character ch,tree tr)
        {
            if (ch.img == ur0||ch.img==ur1||ch.img==ur2||ch.img==ur3 || ch.img == ur4
                || ch.img == dr0 || ch.img == dr1 || ch.img == dr2 || ch.img == dr3 || ch.img == dr4
                ||ch.img==r0 || ch.img == r1 || ch.img == r2 || ch.img == r3 || ch.img == r4
                || ch.img == u0 || ch.img == u1 || ch.img == u2 || ch.img == u3 || ch.img == u4||
               ch.img == ar0 || ch.img == ard0 || ch.img == au0 || ch.img == aru0 )//오른쪽 보고 있을때
            {
                int dx = Math.Abs((ch.x -10)- (tr.x)); //캐릭터오른쪽 +나무왼쪽
                int dy = Math.Abs((ch.y) - (tr.y + 100));
                if (dx <25&&dy<35)
                {                 
                    return true;
                }
                else
                    return false;
            }
            if (ch.img == ul0||ch.img==ul1 || ch.img == ul2||ch.img==ul3 || ch.img == ul4
                || ch.img == dl0 || ch.img == dl1 || ch.img == dl2 || ch.img == dl3 || ch.img == dl4
                || ch.img == l0 || ch.img == l1 || ch.img == l2 || ch.img == l3 || ch.img == l4
                || ch.img == d0 || ch.img == d1 || ch.img == d2 || ch.img == d3 || ch.img == d4
                ||ch.img == ad0 || ch.img == adl0 || ch.img == al0 || ch.img == alu0 )//왼쪽 보고 있을때
            {
                int dx = Math.Abs((ch.x)- (tr.x)-75); //캐릭터왼쪽 + 나무오른쪽
                int dy = Math.Abs((ch.y) - (tr.y + 100));
                if (dx < 35&&dy<35)
                    return true;
                else
                    return false;
            }
            else
                return false;
        }
        bool weapon_pig_crush(character ch, pig an)
        {
            if (ch.img == ur0 || ch.img == ur1 || ch.img == ur2 || ch.img == ur3 || ch.img == ur4
           || ch.img == dr0 || ch.img == dr1 || ch.img == dr2 || ch.img == dr3 || ch.img == dr4
           || ch.img == r0 || ch.img == r1 || ch.img == r2 || ch.img == r3 || ch.img == r4
           || ch.img == u0 || ch.img == u1 || ch.img == u2 || ch.img == u3 || ch.img == u4 ||
            ch.img == ar0 || ch.img == ard0 || ch.img == au0 || ch.img == aru0)//오른쪽 보고 있을때
            {
                int dx = Math.Abs((ch.x +60) - (an.x + 25));
                int dy = Math.Abs((ch.y+20) - (an.y ));
                if (dx < 40 && dy <40 )
                {
                    return true;
                }
                else
                    return false;
            }
            if (ch.img == ul0 || ch.img == ul1 || ch.img == ul2 || ch.img == ul3 || ch.img == ul4
                  || ch.img == dl0 || ch.img == dl1 || ch.img == dl2 || ch.img == dl3 || ch.img == dl4
                  || ch.img == l0 || ch.img == l1 || ch.img == l2 || ch.img == l3 || ch.img == l4
                  || ch.img == d0 || ch.img == d1 || ch.img == d2 || ch.img == d3 || ch.img == d4
                    || ch.img == ad0 || ch.img == adl0 || ch.img == al0 || ch.img == alu0)//왼쪽 보고 있을때
            {
                int dx = Math.Abs((ch.x) - (an.x + 25));
                int dy = Math.Abs((ch.y+20) - (an.y ));
                if (dx < 40 && dy < 40)
                    return true;
                else
                    return false;
            }
            else
                return false;
        }
        bool weapon_ghost_crush(character ch, ghost gs)
        {

            if (ch.img == ur0 || ch.img == ur1 || ch.img == ur2 || ch.img == ur3 || ch.img == ur4
           || ch.img == dr0 || ch.img == dr1 || ch.img == dr2 || ch.img == dr3 || ch.img == dr4
           || ch.img == r0 || ch.img == r1 || ch.img == r2 || ch.img == r3 || ch.img == r4
           || ch.img == u0 || ch.img == u1 || ch.img == u2 || ch.img == u3 || ch.img == u4 ||
            ch.img == ar0 || ch.img == ard0 || ch.img == au0 || ch.img == aru0)//오른쪽 보고 있을때
            {
                int dx = Math.Abs((ch.x + 60) - (gs.x + 15));
                int dy = Math.Abs((ch.y + 20) - (gs.y));
                if (dx < 20 && dy < 40)
                {
                    return true;
                }
                else
                    return false;
            }
            if (ch.img == ul0 || ch.img == ul1 || ch.img == ul2 || ch.img == ul3 || ch.img == ul4
                  || ch.img == dl0 || ch.img == dl1 || ch.img == dl2 || ch.img == dl3 || ch.img == dl4
                  || ch.img == l0 || ch.img == l1 || ch.img == l2 || ch.img == l3 || ch.img == l4
                  || ch.img == d0 || ch.img == d1 || ch.img == d2 || ch.img == d3 || ch.img == d4
                    || ch.img == ad0 || ch.img == adl0 || ch.img == al0 || ch.img == alu0)//왼쪽 보고 있을때
            {
                int dx = Math.Abs((ch.x) - (gs.x + 15));
                int dy = Math.Abs((ch.y + 20) - (gs.y));
                if (dx < 20 && dy < 40)
                    return true;
                else
                    return false;
            }
            else
                return false;
        }
        bool weapon_door_crush(character ch, fence fc)
        {
            int dx = Math.Abs((ch.x + 35) - (fc.x + 40));
            int dy = Math.Abs((ch.y + 50) - (fc.y+15));
            if (dx < 70 && dy < 50)
            {
                return true;
            }
            else
                return false;
        }

        bool unit_object_crush(character ch, tree tr)
        {
            int dx = Math.Abs((ch.x + 15) - (tr.x + 75));
            int dy = Math.Abs((ch.y+10) - (tr.y + 100));
            if (dx <75 && dy < 90)
            {
                return true;
            }
            else
                return false;
        }
        bool unit_stone_crush(character ch, stone st)
        {


            int dx = Math.Abs((ch.x + 35) - (st.x + 15));
            int dy = Math.Abs((ch.y + 60) - (st.y + 15));
            if (dx < 40 && dy < 30)
            {
              
                return true;
            }
            else
                return false;        
        }
        bool unit_wood_crush(character ch, wood wd)
        {
            int dx = Math.Abs((ch.x + 35) - (wd.x + 15));
            int dy = Math.Abs((ch.y + 60) - (wd.y + 15));
            if (dx < 40 && dy < 30)
            {

                return true;
            }
            else
                return false;
        }
        bool unit_meat_crush(character ch, meat mt)
        {
            int dx = Math.Abs((ch.x + 35) - (mt.x + 15));
            int dy = Math.Abs((ch.y + 60) - (mt.y + 15));
            if (dx < 40 && dy < 30)
            {

                return true;
            }
            else
                return false;
        }
        int attack_state = 0;
        int[] px = new int[10];
        int[] py = new int[10];
        int[] gx = new int[10];
        int[] gy = new int[10];
        private void pig_move_tick(object sender, EventArgs e)
        {
            for (int i = 0; i < pigs.Count; i++)
            {
                if (pigs[i].x < bx || pigs[i].x + 50 > 1324)
                    px[i] =- px[i];
                if (pigs[i].y < by || pigs[i].y + 50 > 1100)
                    py[i] =- py[i];


                for (int s = 0; s < fences.Count; s++)
                {
                    if (fences[s].fencestate != 1)
                    {
                        if (pigs[i].y + py[i] + pigs[i].height + 30 > fences[s].y && fences[s].y + fences[s].height - 5 > pigs[i].y + py[i] && pigs[i].x + px[i] + 25 < fences[s].x + fences[s].width && pigs[i].x + px[i] + pigs[i].width + 55 > fences[s].x)
                        {
                            py[i] = -py[i];
                            px[i] = -px[i];
                        }
                    }
                    else
                    {
                        if (pigs[i].y + pigs[i].height + 25 > fences[s].y - 25 && fences[s].y - 40 + fences[s].fencestate - 20 > pigs[i].y && pigs[i].x + 50 < fences[s].x + fences[s].fencestate && pigs[i].x + pigs[i].width + 55 > fences[s].x)
                        {
                            px[i] = -px[i];
                            py[i] = -py[i];
                        }
                    }
                }
                pigs[i].x += px[i];
                pigs[i].y += py[i];
                if (px[i] > 0)
                {
                    if (py[i] < 0)
                        pigs[i].img = p_ur;
                    else if (py[i] > 0)
                        pigs[i].img = p_dr;
                    else
                        pigs[i].img = p_r;
                }
                if (px[i] < 0)
                {
                    if (py[i] < 0)
                        pigs[i].img = p_ul;
                    else if (py[i] > 0)
                        pigs[i].img = p_dl;
                    else
                        pigs[i].img = p_l;
                }
                if (px[i] == 0 && py[i] > 0)
                    pigs[i].img = p_d;
                if (px[i] == 0 && py[i] < 0)
                    pigs[i].img = p_u;
            }
        }
        private void ghost_move_tick(object sender, EventArgs e)
        {
            for (int i = 0; i < ghosts.Count; i++)
            {
                if (ghosts[i].x < bx || ghosts[i].x + 50 > 1324)
                    gx[i] =- gx[i];
                if (ghosts[i].y < by || ghosts[i].y + 50 > 1100)
                    gy[i] =- gy[i];


                for (int s = 0; s < fences.Count; s++)
                {
                    if (fences[s].fencestate != 1)
                    {
                        if (ghosts[i].y + gy[i] + ghosts[i].height + 30 > fences[s].y && fences[s].y + fences[s].height - 5 > ghosts[i].y + gy[i] && ghosts[i].x + gx[i] + 25 < fences[s].x + fences[s].width && ghosts[i].x + gx[i] + ghosts[i].width + 55 > fences[s].x)
                        {
                            gy[i] = -gy[i];
                            gx[i] = -gx[i];
                        }
                    }
                    else
                    {
                        if (ghosts[i].y + ghosts[i].height + 25 > fences[s].y - 25 && fences[s].y - 40 + fences[s].fencestate - 20 > ghosts[i].y && ghosts[i].x + 50 < fences[s].x + fences[s].fencestate && ghosts[i].x + ghosts[i].width + 55 > fences[s].x)
                        {
                            gx[i] = -gx[i];
                            gy[i] = -gy[i];
                        }
                    }
                }



                ghosts[i].x += gx[i];
                ghosts[i].y += gy[i];
                if(gx[i]>0)
                {
                    if (gy[i] < 0)
                        ghosts[i].img = g_ur;
                    else if (gy[i] > 0)
                        ghosts[i].img = g_dr;
                    else
                        ghosts[i].img = g_r;
                }
                if (gx[i] < 0)
                {
                    if (gy[i] < 0)
                        ghosts[i].img = g_ul;
                    else if (gy[i] > 0)
                        ghosts[i].img = g_dl;
                    else
                        ghosts[i].img = g_l;
                }
                if (gx[i] == 0 && gy[i] > 0)
                    ghosts[i].img = g_d;
                if (gx[i] == 0 && gy[i] < 0)
                    ghosts[i].img = g_u;
            }
        }
        private void PictureBox1_MouseEnter(object sender, EventArgs e)
        {
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
        }
        private void PictureBox1_MouseLeave(object sender, EventArgs e)
        {

        }
        private void Form1_MouseEnter(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
        }

        //울타리 정보
        int f1x = -500;
        int f1y = -500;
        int f2x = -500;
        int f2y= - 500;
        int f3x = -500;
        int f3y = -500;
        bool fencecheck1 = false;//가로울타리
        bool fencecheck2 = false;//세로울타리
        bool fencecheck3 = false;//울타리 문
        bool fencedooropen = false;

        private void Button2_Click(object sender, EventArgs e)
        {
            if (i_wood >= 2)
            {                
                i_wood -= 2;                
                label1.Text = i_wood.ToString();                             
                fencecheck1 = true;
                fencecheck2 = false;
                fencecheck3 = false;
            }
            else
            {
                MessageBox.Show("재료가 부족합니다.(재료: 나무 2 )");
                return;
            }            
        }
        private void Button4_Click(object sender, EventArgs e)
        {
            if (i_wood >= 2)
            {
                i_wood -= 2;
                label1.Text = i_wood.ToString();
                fencecheck1 = false;
                fencecheck2 = true;
                fencecheck3 = false;
            }
            else
            {
                MessageBox.Show("재료가 부족합니다.(재료: 나무 2 )");
                return;
            }
        }


        private void Button5_Click(object sender, EventArgs e)
        {
            if (i_wood >= 2)
            {
                i_wood -= 2;
                label1.Text = i_wood.ToString();
                fencecheck1 = false;
                fencecheck2 = false;
                fencecheck3 = true;
            }
            else
            {
                MessageBox.Show("재료가 부족합니다.(재료: 나무 2 )");
                return;
            }
        }
        List<fence> home_fence = new List<fence>();
        bool[] fence_visited = new bool[100];
        Point[] Points1 = new Point[100];
        Point[] Points2 = new Point[100];
        List<Point> points = new List<Point>();
        List<Point> points2 = new List<Point>();

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            int a = fences.Count;
            if (fencecheck1)
            {
                if (!fence_crush(e.X, e.Y, 80, 30))
                {
                    fencecheck1 = !fencecheck1;
                    fences.Add(new fence(f1x, f1y, 80, 30, 30, 0));//0이면 가로
                    f1x = -500;
                    f1y = -500;
                }
                else
                    MessageBox.Show("여기에 건설할 수 없습니다.");
                //  fencedraw1 = true;               
            }
            if (fencecheck2)
            {
                if (!fence_crush(e.X, e.Y, 30, 80))
                {
                    fencecheck2 = !fencecheck2;
                    fences.Add(new fence(f2x, f2y, 30, 80, 30, 1));//1이면 세로
                    f2x = -500;
                    f2y = -500;
                }
                else
                    MessageBox.Show("여기에 건설할 수 없습니다.");

            }

            if (fencecheck3)
            {
                if (!fence_crush(e.X, e.Y, 80, 30))
                {
                    fencecheck3 = !fencecheck3;
                    fences.Add(new fence(f3x, f3y, 80, 30, 30, 2));//2이면 문
                    f3x = -500;
                    f3y = -500;
                    //  fencedraw2 = true;            
                }
                else
                    MessageBox.Show("여기에 건설할 수 없습니다.");

            }
            if (a!=fences.Count)
            {
                for (int i = 0; i < 100; i++)
                {
                    fence_visited[i] = false;
                }
                for (int f = 0; f < fences.Count; f++)
                {
                    if (fences[f].fencestate == 2) { 

                    
                    home_fence.Add(fences[f]);
                        if (Home_check(f))// 문이 있는 울타리의 인덱스  입력
                        {
                            MessageBox.Show("집이 완성 되었습니다.");
                            // 집클래스 생성// 집안에는 밝기를 다르게 
                            p3 = new Point[home_fence.Count];
                            for (int i = 0;i < home_fence.Count;i++)
                            {                               
                                if (home_fence[i].fencestate == 0 )
                                {
                                    if (home_fence[i].y < home_fence[0].y - 40)
                                    {
                                        Points1[i].X = home_fence[i].x;
                                        Points1[i].Y = home_fence[i].y+30;
                                        points.Add(Points1[i]);
                                        Points2[i].X = home_fence[i].x + 80;
                                        Points2[i].Y = home_fence[i].y+30;
                                        points.Add(Points2[i]);
                                    }
                                    else
                                    {
                                        Points1[i].X = home_fence[i].x+80;
                                        Points1[i].Y = home_fence[i].y;
                                        points.Add(Points1[i]);
                                        Points2[i].X = home_fence[i].x;
                                        Points2[i].Y = home_fence[i].y;
                                        points.Add(Points2[i]);
                                    }
                                }
                                else if(home_fence[i].fencestate == 2)
                                {
                                    Points1[i].X = home_fence[i].x + 80;
                                    Points1[i].Y = home_fence[i].y;
                                    points.Add(Points1[i]);
                                    Points2[i].X = home_fence[i].x;
                                    Points2[i].Y = home_fence[i].y;
                                    points.Add(Points2[i]);
                                }
                                else
                                {
                                    if (home_fence[i].x < home_fence[0].x + 40)
                                    {
                                        Points1[i].X = home_fence[i].x+30;
                                        Points1[i].Y = home_fence[i].y + 80;
                                        points.Add(Points1[i]);
                                        Points2[i].X = home_fence[i].x+30;
                                        Points2[i].Y = home_fence[i].y;
                                        points.Add(Points2[i]);
                                    }
                                    else
                                    {
                                        Points1[i].X = home_fence[i].x;
                                        Points1[i].Y = home_fence[i].y;
                                        points.Add(Points1[i]);
                                        Points2[i].X = home_fence[i].x;
                                        Points2[i].Y = home_fence[i].y + 80;
                                        points.Add(Points2[i]);
                                    }                                    
                                }                                        
                            }
                            //p3[0].X = (int)(points[0].X + points[15].X) / 2;
                            //p3[0].Y = (int)(points[0].Y + points[15].Y) / 2;

                            //p3[1].X = (points[1].X + points[2].X) / 2;
                            //p3[1].Y = (points[1].Y + points[2].Y) / 2;

                            //p3[2].X = (points[3].X + points[4].X) / 2;
                            //p3[2].Y = (points[3].Y + points[4].Y) / 2;

                            //p3[3].X = (points[5].X + points[6].X) / 2;
                            //p3[3].Y = (points[5].Y + points[6].Y) / 2;

                            //p3[4].X = (points[7].X + points[8].X) / 2;
                            //p3[4].Y = (points[7].Y + points[8].Y) / 2;


                            //p3[5].X = (points[9].X + points[10].X) / 2;
                            //p3[5].Y = (points[9].Y + points[10].Y) / 2;


                            //p3[6].X = (points[11].X + points[12].X) / 2;
                            //p3[6].Y = (points[11].Y + points[12].Y) / 2;


                            //p3[7].X = (points[13].X + points[14].X) / 2;
                            //p3[7].Y = (points[13].Y + points[14].Y) / 2;
                            p3[0].X = (points[0].X + points[points.Count - 1].X) / 2;
                            p3[0].Y = (points[0].Y + points[points.Count - 1].Y) / 2;

                            for (int i = 1; i < points.Count - 2; i += 2)
                            {
                                //points2리스트에 넣기
                                p3[(i / 2) + 1].X = (points[i].X + points[i + 1].X) / 2;
                                p3[(i / 2) + 1].Y = (points[i].Y + points[i + 1].Y) / 2;
                            }

                        }
                    }                    
                }
            }
        }

        bool Home_check(int index)
        {
            fence_visited[index] = true;  // 들어온 인덱스는 체크처리
            if (Math.Abs((fences[index].x - home_fence[0].x - 80)) < 30 && Math.Abs((home_fence[0].y - fences[index].y)) < 30 &&fences[index].fencestate!=1)
                return true; //그인덱스가 문오른쪽과 같으면 true                     
            if (Math.Abs((fences[index].x - home_fence[0].x - 80)) < 30 && Math.Abs((home_fence[0].y - 80 - fences[index].y))< 30 && fences[index].fencestate == 1)
                return true;
            if(Math.Abs((fences[index].x - home_fence[0].x - 80)) < 30 && Math.Abs((home_fence[0].y+80 - fences[index].y)) < 30 && fences[index].fencestate == 1)
                return true;
            for (int i = 0; i < fences.Count; i++)
            { // 인덱스가 전부다 방문했으면 false 리턴
                if (fence_visited[i] == false) break;
                if(i==fences.Count-1)
                    if (fence_visited[i] == true)
                        return false;                
            }

            if (fences[index].fencestate == 0 || fences[index].fencestate == 2)
            {
                for (int i = 0; i < fences.Count; i++)
                {
                    if (i == index) continue;
                    if (Math.Abs((fences[index].y - 80) - (fences[i].y)) < 30 && Math.Abs((fences[index].x) - fences[i].x) < 30 && fences[i].fencestate == 1)      //위쪽에 있을때         
                    {
                        if (fence_visited[i] == false) { home_fence.Add(fences[i]); return Home_check(i); }
                    }// 그펜스가 방문을 안했으면 인덱스 추가
                    else if (Math.Abs((fences[index].x - 80) - (fences[i].x)) < 30 && Math.Abs((fences[index].y) - fences[i].y) < 30 && fences[i].fencestate != 1)      //왼쪽에 있을때
                    {
                        if (fence_visited[i] == false)
                        {
                            home_fence.Add(fences[i]);
                            return Home_check(i);
                        }
                    } // 그펜스가 방문을 안했으면 인덱스 추가
                    else if (Math.Abs((fences[index].y) - (fences[i].y)) < 30 && Math.Abs((fences[index].x) - fences[i].x) < 30 && fences[i].fencestate == 1)      //아래에 있을때
                    {
                        if (fence_visited[i] == false)
                        {
                            home_fence.Add(fences[i]);
                            return Home_check(i);
                        }
                    }// 그펜스가 방문을 안했으면 인덱스 추가
                    else if (Math.Abs((fences[index].y - 80) - (fences[i].y)) < 30 && Math.Abs((fences[index].x + 80) - fences[i].x) < 30 && fences[i].fencestate == 1)      //위쪽에 있을때         
                    {
                        if (fence_visited[i] == false) { home_fence.Add(fences[i]); return Home_check(i); }
                    }// 그펜스가 방문을 안했으면 인덱스 추가
                    else if (Math.Abs((fences[index].y) - (fences[i].y)) < 30 && Math.Abs((fences[index].x+80) - fences[i].x) < 30 && fences[i].fencestate == 1)      //아래에 있을때
                    {
                        if (fence_visited[i] == false)
                        {
                            home_fence.Add(fences[i]);
                            return Home_check(i);
                        }
                    }// 그펜스가 방문을 안했으면 인덱스 추가
                    else if (Math.Abs((fences[index].x + 80) - (fences[i].x)) < 30 && Math.Abs((fences[index].y) - fences[i].y) < 30 && fences[i].fencestate != 1)      //왼쪽에 있을때
                    {
                        if (fence_visited[i] == false)
                        {
                            home_fence.Add(fences[i]);
                            return Home_check(i);
                        }
                    } // 그펜스가 방문을 안했으면 인덱스 추가
                    else if (i == fences.Count - 1)
                    {
                        home_fence.RemoveAt(home_fence.Count - 1);
                    }

                }
                
                    
                    // 근접한곳에 펜스가 없으면 home 에 들어갈수 없으니 꺼내
                    if (home_fence.Count == 0)
                        return false; // 꺼냇는데 문 하나남았으면 false
                    else
                        return Home_check(fences.IndexOf(home_fence[home_fence.Count - 1])); // 홈으로지정된 펜스의 마지막 인덱스를 넣음
                
            }
            else
            {
                for (int i = 0; i < fences.Count; i++)
                {
                    if (i == index) continue;
                    if (Math.Abs((fences[index].y - 80) - (fences[i].y)) < 30 && Math.Abs((fences[index].x) - fences[i].x) < 30 && fences[i].fencestate == 1)      //위쪽에 있을때         
                    {
                        if (fence_visited[i] == false) { home_fence.Add(fences[i]); return Home_check(i); }
                    }// 그펜스가 방문을 안했으면 인덱스 추가               
                    else if (Math.Abs((fences[index].x - 80) - (fences[i].x)) < 30 && Math.Abs((fences[index].y) - fences[i].y) < 30 && fences[i].fencestate != 1)      //왼쪽에 있을때
                    {
                        if (fence_visited[i] == false) { home_fence.Add(fences[i]); return Home_check(i); }
                    } // 그펜스가 방문을 안했으면 인덱스 추가
                    else if (Math.Abs((fences[index].x) - (fences[i].x)) < 30 && Math.Abs((fences[index].y) - fences[i].y) < 30 && fences[i].fencestate != 1)      //오른쪽에 있을때
                    {
                        if (fence_visited[i] == false) { home_fence.Add(fences[i]); return Home_check(i); }
                    }// 그펜스가 방문을 안했으면 인덱스 추가
                    else if (Math.Abs((fences[index].x - 80) - (fences[i].x)) < 30 && Math.Abs((fences[index].y+80) - fences[i].y) < 30 && fences[i].fencestate != 1)      //왼쪽에 있을때
                    {
                        if (fence_visited[i] == false) { home_fence.Add(fences[i]); return Home_check(i); }
                    } // 그펜스가 방문을 안했으면 인덱스 추가
                    else if (Math.Abs((fences[index].x) - (fences[i].x)) < 30 && Math.Abs((fences[index].y+80) - fences[i].y) < 30 && fences[i].fencestate != 1)      //오른쪽에 있을때
                    {
                        if (fence_visited[i] == false) { home_fence.Add(fences[i]); return Home_check(i); }
                    }// 그펜스가 방문을 안했으면 인덱스 추가
                    else if (Math.Abs((fences[index].y +80 ) - (fences[i].y)) < 30 && Math.Abs((fences[index].x) - fences[i].x) < 30 && fences[i].fencestate == 1)      //위쪽에 있을때         
                    {
                        if (fence_visited[i] == false) { home_fence.Add(fences[i]); return Home_check(i); }
                    }// 그펜스가 방문을 안했으면 인덱스 추가               
                    else if(i==fences.Count-1)
                    {
                        home_fence.RemoveAt(home_fence.Count - 1);
                    }
                }                
                    
                    // 근접한곳에 펜스가 없으면 home 에 들어갈수 없으니 꺼내
                    if (home_fence.Count == 0)
                        return false; // 꺼냇는데 문 하나남았으면 false
                    else
                        return Home_check(fences.IndexOf(home_fence[home_fence.Count - 1])); // 홈으로지정된 펜스의 마지막 인덱스를 넣음
                
            }
            
            return false;
        }
        bool fireon = false;
        private void Button3_Click(object sender, EventArgs e)
        {
                
            if (i_wood >= 1 && i_stone >= 1)
            {                                
                i_wood -= 1;
                i_stone -= 1;
                fireon = true;
                label1.Text = i_wood.ToString();
                label2.Text = i_stone.ToString();
                MessageBox.Show("횃불를 얻었습니다.");
                
            }
            else
            {
                MessageBox.Show("재료가 부족합니다.(재료:나무 1, 돌 1");
                return;
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            for (int c = 0; c < chars.Count; c++)
            {
                if (i_meat > 0)
                {
                    i_meat--;
                    label3.Text = i_meat.ToString();
                    chars[0].hungry += 10; //허기짐 +10;
                    if (chars[0].health < 90)
                        chars[0].health += 10;
                    label4.Text = chars[0].hungry.ToString();
                    label6.Text = chars[0].health.ToString();
                }
                else
                {
                    MessageBox.Show("고기가없어요(돼지를 잡으면 고기가 나와요)");
                    return;
                }
            }
        }

    

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (fencecheck1)
            {
                f1x = e.X-40;
                f1y = e.Y-15;
            }
            if(fencecheck2)
            {
                f2x = e.X - 15;
                f2y = e.Y - 40;
            }
            if (fencecheck3)
            {
                f3x = e.X - 40;
                f3y = e.Y - 15;
            }

            Invalidate();
        }

        private void Button1_Click(object sender, EventArgs e)
        {

            if (i_wood >= 2 && i_stone >= 1
                )
            {
                chars[0].weapon = 1;
                i_wood -= 2;
                i_stone -= 1;
                label1.Text = i_wood.ToString();
                label2.Text = i_stone.ToString();
                if (chars[0].img == ul0 || chars[0].img == ul1 || chars[0].img == ul2 || chars[0].img == ul3 || chars[0].img == ul4)
                    chars[0].img = xul0;
                if (chars[0].img == dl0 || chars[0].img == dl1 || chars[0].img == dl2 || chars[0].img == dl3 || chars[0].img == dl4)
                    chars[0].img = xdl0;
                if (chars[0].img == l0 || chars[0].img == l1 || chars[0].img == l2 || chars[0].img == l3 || chars[0].img == l4)
                    chars[0].img = xl0;
                if (chars[0].img == d0 || chars[0].img == d1 || chars[0].img == d2 || chars[0].img == d3 || chars[0].img == d4)
                    chars[0].img = xd0;
                if (chars[0].img == ur0 || chars[0].img == ur1 || chars[0].img == ur2 || chars[0].img == ur3 || chars[0].img == ur4)
                    chars[0].img = xur0;
                if (chars[0].img == dr0 || chars[0].img == dr1 || chars[0].img == dr2 || chars[0].img == dr3 || chars[0].img == dr4)
                    chars[0].img = xdr0;
                if (chars[0].img == r0 || chars[0].img == r1 || chars[0].img == r2 || chars[0].img == r3 || chars[0].img == r4)
                    chars[0].img = xr0;
                if (chars[0].img == u0 || chars[0].img == u1 || chars[0].img == u2 || chars[0].img == u3 || chars[0].img == u4)
                    chars[0].img = xu0;            
                MessageBox.Show("돌도끼를 얻었습니다.");
            }
            else
                {
                    MessageBox.Show("재료가 부족합니다.(재료: 나무 2 돌 1");
                    return;
                }                                
        }
        private void attack_tick(object sender, EventArgs e)
        {

            attack_state++;
            //spacebar눌렀을때 통신
            for (int c = 0; c < chars.Count; c++)
            {
                if (chars[0].img == xur0 || chars[0].img == xur1 || chars[0].img == xur2 || chars[0].img == xur3 || chars[0].img == xur4)
                    chars[0].img = aru0;
                if (chars[0].img == xdr0 || chars[0].img == xdr1 || chars[0].img == xdr2 || chars[0].img == xdr3 || chars[0].img == xdr4)
                    chars[0].img = ard0;
                if (chars[0].img == xr0 || chars[0].img == xr1 || chars[0].img == xr2 || chars[0].img == xr3 || chars[0].img == xr4)
                    chars[0].img = ar0;
                if (chars[0].img == xu0 || chars[0].img == xu1 || chars[0].img == xu2 || chars[0].img == xu3 || chars[0].img == xu4)
                    chars[0].img = au0;
                if (chars[0].img == xul0 || chars[0].img == xul1 || chars[0].img == xul2 || chars[0].img == xul3 || chars[0].img == xul4)
                    chars[0].img = alu0;
                if (chars[0].img == xdl0 || chars[0].img == xdl1 || chars[0].img == xdl2 || chars[0].img == xdl3 || chars[0].img == xdl4)
                    chars[0].img = adl0;
                if (chars[0].img == xl0 || chars[0].img == xl1 || chars[0].img == xl2 || chars[0].img == xl3 || chars[0].img == xl4)
                    chars[0].img = al0;
                if (chars[0].img == xd0 || chars[0].img == xd1 || chars[0].img == xd2 || chars[0].img == xd3 || chars[0].img == xd4)
                    chars[0].img = ad0;



                for (int i = 0; i < trees.Count; i++)
                {
                    if (weapon_tree_crush(chars[0], trees[i]))//오른쪽 보고있을때
                    {
                        trees[i].health -= chars[0].attack();
                        if (trees[i].health <= 0)
                        {
                            trees[i].x += 57;
                            trees[i].y += 162;
                            woods.Add(new wood(trees[i].x, trees[i].y + 30, 30, 30, wd));
                            trees[i].width = 35;
                            trees[i].height = 38;
                            trees[i].health = 100;
                            trees[i].img = tr1;
                            to[i] = false;
                        }

                    }
                }
                for (int i = 0; i < pigs.Count; i++)
                {
                    if (weapon_pig_crush(chars[0], pigs[i]))
                    {
                        pigs[i].health -= chars[0].attack();
                        if (pigs[i].health <= 0)
                        {
                            meats.Add(new meat(pigs[i].x + 10, pigs[i].y + 30, 30, 30, mt));
                            pigs.RemoveAt(i);
                        }
                    }
                }
                for (int i = 0; i < ghosts.Count; i++)
                {
                    if (weapon_ghost_crush(chars[0], ghosts[i]))//
                    {
                        chars[0].health -= 1;
                        ghosts[i].health -= chars[0].attack();
                        if (ghosts[i].health <= 0)
                        {
                            ghosts.RemoveAt(i);
                            if(chars[0].brain<91)
                                chars[0].brain += 10;//정신+10 밸런스수정필요                        
                            label5.Text = chars[0].brain.ToString();

                        }
                    }
                }
                for (int i = 0; i < fences.Count; i++)
                {
                    if (weapon_door_crush(chars[0], fences[i]))
                    {
                        fences[i].health -= chars[0].attack();
                        if (fences[i].health <= 0)
                        {
                            fences.RemoveAt(i);
                        }
                    }
                }
            }
            if (attack_state == 1)
            {
                attack_state = 0;
                attack_timer.Stop();
            }
            Invalidate();
        }

        static int br_on = 0, bl_on = 0, bu_on = 0, bd_on = 0;   //----키보드 눌림저장 스위치 변수g        
        

        static int speed = 1;
        private void Character_Move_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Right)
            {
               
                br_on = 1; ur_on = 1;
             
              
            }
            if (e.KeyCode == Keys.Left)
            {                
                bl_on = 1; ul_on = 1;                        
            }
            if (e.KeyCode == Keys.Up)
            {
                bu_on = 1; uu_on = 1;               
            }
            if (e.KeyCode == Keys.Down)
            {
                bd_on = 1; ud_on = 1;              
            }
            if (e.KeyCode == Keys.I)
            {
                if (inven.Opacity == 0)
                    inven.Opacity = 100;
                else
                    inven.Opacity = 0;
            }
            if (e.KeyCode == Keys.Z)
            {
                for(int i=0;i<stones.Count;i++)
                {
                    if(unit_stone_crush(chars[0],stones[i]))
                    {
                        i_stone++;
                        inven.label2.Text = i_stone.ToString() + " 개";
                        label2.Text = i_stone.ToString();
                        if (chars[0].img == u0 || chars[0].img == u1 || chars[0].img == u2 || chars[0].img == u3 || chars[0].img == u4)
                        {
                            chars[0].img = uz0;                           
                        }
                        if (chars[0].img == ur0 || chars[0].img == ur1 || chars[0].img == ur2 || chars[0].img == ur3 || chars[0].img == ur4)
                        {
                            chars[0].img = urz0;
                        }
                        if (chars[0].img == ul0 || chars[0].img == ul1 || chars[0].img == ul2 || chars[0].img == ul3 || chars[0].img == ul4)
                        {
                            chars[0].img = luz0;
                        }
                        if (chars[0].img == r0 || chars[0].img == r1 || chars[0].img == r2 || chars[0].img == r3 || chars[0].img == r4)
                        {
                            chars[0].img = rz0;
                        }
                        if (chars[0].img == dr0 || chars[0].img == dr1 || chars[0].img == dr2 || chars[0].img == dr3 || chars[0].img == dr4)
                        {
                            chars[0].img = rdz0;
                        }
                        if (chars[0].img == l0 || chars[0].img == l1 || chars[0].img == l2 || chars[0].img == l3 || chars[0].img == l4)
                        {
                            chars[0].img = lz0;
                        }
                        if (chars[0].img == dl0 || chars[0].img == dl1 || chars[0].img == dl2 || chars[0].img == dl3 || chars[0].img == dl4)
                        {
                            chars[0].img = dlz0;
                        }
                        if (chars[0].img == d0 || chars[0].img == d1 || chars[0].img == d2 || chars[0].img == d3 || chars[0].img == d4)
                        {
                            chars[0].img = dz0;
                        }

                        if (chars[0].img == xu0 || chars[0].img == xu1 || chars[0].img == xu2 || chars[0].img == xu3 || chars[0].img == xu4)
                        {
                            chars[0].img = xuz0;
                        }
                        if (chars[0].img == xur0 || chars[0].img == xur1 || chars[0].img == xur2 || chars[0].img == xur3 || chars[0].img == xur4)
                        {
                            chars[0].img = xurz0;
                        }
                        if (chars[0].img == xul0 || chars[0].img == xul1 || chars[0].img == xul2 || chars[0].img == xul3 || chars[0].img == xul4)
                        {
                            chars[0].img = xluz0;
                        }
                        if (chars[0].img == xr0 || chars[0].img == xr1 || chars[0].img == xr2 || chars[0].img == xr3 || chars[0].img == xr4)
                        {
                            chars[0].img = xrz0;
                        }
                        if (chars[0].img == xdr0 || chars[0].img == xdr1 || chars[0].img == xdr2 || chars[0].img == xdr3 || chars[0].img == xdr4)
                        {
                            chars[0].img = xrdz0;
                        }
                        if (chars[0].img == xl0 || chars[0].img == xl1 || chars[0].img == xl2 || chars[0].img == xl3 || chars[0].img == xl4)
                        {
                            chars[0].img = xlz0;
                        }
                        if (chars[0].img == xdl0 || chars[0].img == xdl1 || chars[0].img == xdl2 || chars[0].img == xdl3 || chars[0].img == xdl4)
                        {
                            chars[0].img = xdlz0;
                        }
                        if (chars[0].img == xd0 || chars[0].img == xd1 || chars[0].img == xd2 || chars[0].img == xd3 || chars[0].img == xd4)
                        {
                            chars[0].img = xdz0;
                        }
                        stones.RemoveAt(i);                        
                    }                    

                }
                for(int i=0;i<woods.Count;i++)
                {
                    if (unit_wood_crush(chars[0], woods[i]))
                    {
                        i_wood++;
                        inven.label1.Text =i_wood.ToString() + " 개";
                        label1.Text = i_wood.ToString();
                        if (chars[0].img == u0 || chars[0].img == u1 || chars[0].img == u2 || chars[0].img == u3 || chars[0].img == u4)
                        {
                            chars[0].img = uz0;
                        }
                        if (chars[0].img == ur0 || chars[0].img == ur1 || chars[0].img == ur2 || chars[0].img == ur3 || chars[0].img == ur4)
                        {
                            chars[0].img = urz0;
                        }
                        if (chars[0].img == ul0 || chars[0].img == ul1 || chars[0].img == ul2 || chars[0].img == ul3 || chars[0].img == ul4)
                        {
                            chars[0].img = luz0;
                        }
                        if (chars[0].img == r0 || chars[0].img == r1 || chars[0].img == r2 || chars[0].img == r3 || chars[0].img == r4)
                        {
                            chars[0].img = rz0;
                        }
                        if (chars[0].img == dr0 || chars[0].img == dr1 || chars[0].img == dr2 || chars[0].img == dr3 || chars[0].img == dr4)
                        {
                            chars[0].img = rdz0;
                        }
                        if (chars[0].img == l0 || chars[0].img == l1 || chars[0].img == l2 || chars[0].img == l3 || chars[0].img == l4)
                        {
                            chars[0].img = lz0;
                        }
                        if (chars[0].img == dl0 || chars[0].img == dl1 || chars[0].img == dl2 || chars[0].img == dl3 || chars[0].img == dl4)
                        {
                            chars[0].img = dlz0;
                        }
                        if (chars[0].img == d0 || chars[0].img == d1 || chars[0].img == d2 || chars[0].img == d3 || chars[0].img == d4)
                        {
                            chars[0].img = dz0;
                        }

                        if (chars[0].img == xu0 || chars[0].img == xu1 || chars[0].img == xu2 || chars[0].img == xu3 || chars[0].img == xu4)
                        {
                            chars[0].img = xuz0;
                        }
                        if (chars[0].img == xur0 || chars[0].img == xur1 || chars[0].img == xur2 || chars[0].img == xur3 || chars[0].img == xur4)
                        {
                            chars[0].img = xurz0;
                        }
                        if (chars[0].img == xul0 || chars[0].img == xul1 || chars[0].img == xul2 || chars[0].img == xul3 || chars[0].img == xul4)
                        {
                            chars[0].img = xluz0;
                        }
                        if (chars[0].img == xr0 || chars[0].img == xr1 || chars[0].img == xr2 || chars[0].img == xr3 || chars[0].img == xr4)
                        {
                            chars[0].img = xrz0;
                        }
                        if (chars[0].img == xdr0 || chars[0].img == xdr1 || chars[0].img == xdr2 || chars[0].img == xdr3 || chars[0].img == xdr4)
                        {
                            chars[0].img = xrdz0;
                        }
                        if (chars[0].img == xl0 || chars[0].img == xl1 || chars[0].img == xl2 || chars[0].img == xl3 || chars[0].img == xl4)
                        {
                            chars[0].img = xlz0;
                        }
                        if (chars[0].img == xdl0 || chars[0].img == xdl1 || chars[0].img == xdl2 || chars[0].img == xdl3 || chars[0].img == xdl4)
                        {
                            chars[0].img = xdlz0;
                        }
                        if (chars[0].img == xd0 || chars[0].img == xd1 || chars[0].img == xd2 || chars[0].img == xd3 || chars[0].img == xd4)
                        {
                            chars[0].img = xdz0;
                        }
                        woods.RemoveAt(i);
                    }
                }
                for(int i=0;i<meats.Count;i++)
                {
                    if (unit_meat_crush(chars[0], meats[i]))
                    {
                        i_meat++;
                        inven.label3.Text= i_meat.ToString() + " 개";
                        label3.Text = i_meat.ToString();
                        if (chars[0].img == u0 || chars[0].img == u1 || chars[0].img == u2 || chars[0].img == u3 || chars[0].img == u4)
                        {
                            chars[0].img = uz0;
                        }
                        if (chars[0].img == ur0 || chars[0].img == ur1 || chars[0].img == ur2 || chars[0].img == ur3 || chars[0].img == ur4)
                        {
                            chars[0].img = urz0;
                        }
                        if (chars[0].img == ul0 || chars[0].img == ul1 || chars[0].img == ul2 || chars[0].img == ul3 || chars[0].img == ul4)
                        {
                            chars[0].img = luz0;
                        }
                        if (chars[0].img == r0 || chars[0].img == r1 || chars[0].img == r2 || chars[0].img == r3 || chars[0].img == r4)
                        {
                            chars[0].img = rz0;
                        }
                        if (chars[0].img == dr0 || chars[0].img == dr1 || chars[0].img == dr2 || chars[0].img == dr3 || chars[0].img == dr4)
                        {
                            chars[0].img = rdz0;
                        }
                        if (chars[0].img == l0 || chars[0].img == l1 || chars[0].img == l2 || chars[0].img == l3 || chars[0].img == l4)
                        {
                            chars[0].img = lz0;
                        }
                        if (chars[0].img == dl0 || chars[0].img == dl1 || chars[0].img == dl2 || chars[0].img == dl3 || chars[0].img == dl4)
                        {
                            chars[0].img = dlz0;
                        }
                        if (chars[0].img == d0 || chars[0].img == d1 || chars[0].img == d2 || chars[0].img == d3 || chars[0].img == d4)
                        {
                            chars[0].img = dz0;
                        }


                        if (chars[0].img == xu0 || chars[0].img == xu1 || chars[0].img == xu2 || chars[0].img == xu3 || chars[0].img == xu4)
                        {
                            chars[0].img = xuz0;
                        }
                        if (chars[0].img == xur0 || chars[0].img == xur1 || chars[0].img == xur2 || chars[0].img == xur3 || chars[0].img == xur4)
                        {
                            chars[0].img = xurz0;
                        }
                        if (chars[0].img == xul0 || chars[0].img == xul1 || chars[0].img == xul2 || chars[0].img == xul3 || chars[0].img == xul4)
                        {
                            chars[0].img = xluz0;
                        }
                        if (chars[0].img == xr0 || chars[0].img == xr1 || chars[0].img == xr2 || chars[0].img == xr3 || chars[0].img == xr4)
                        {
                            chars[0].img = xrz0;
                        }
                        if (chars[0].img == xdr0 || chars[0].img == xdr1 || chars[0].img == xdr2 || chars[0].img == xdr3 || chars[0].img == xdr4)
                        {
                            chars[0].img = xrdz0;
                        }
                        if (chars[0].img == xl0 || chars[0].img == xl1 || chars[0].img == xl2 || chars[0].img == xl3 || chars[0].img == xl4)
                        {
                            chars[0].img = xlz0;
                        }
                        if (chars[0].img == xdl0 || chars[0].img == xdl1 || chars[0].img == xdl2 || chars[0].img == xdl3 || chars[0].img == xdl4)
                        {
                            chars[0].img = xdlz0;
                        }
                        if (chars[0].img == xd0 || chars[0].img == xd1 || chars[0].img == xd2 || chars[0].img == xd3 || chars[0].img == xd4)
                        {
                            chars[0].img = xdz0;
                        }
                        meats.RemoveAt(i);
                    }
                }
            }
            if (e.KeyCode == Keys.Space) { attack_timer.Start(); }
            if (e.KeyCode == Keys.E)
            {
                for (int i = 0; i < fences.Count; i++)
                {
                    if (fences[i].fencestate == 2 && weapon_door_crush(chars[0], fences[i]) && fencedooropen)
                    {
                        fencedooropen = !fencedooropen;
                        fences[i].width = 30;
                        fences[i].height = 80;
                    }
                    if (fences[i].fencestate == 2 && weapon_door_crush(chars[0], fences[i]) && !fencedooropen)
                    {
                        fencedooropen = !fencedooropen;
                        fences[i].width = 80;
                        fences[i].height = 30;
                    }
                }
            }
        }
        private void Character_Move_KeyUp(object sender, KeyEventArgs e)
        {
            
            if (e.KeyCode == Keys.Right)
            {
               
                br_on = 0; ur_on = 0;
            }    //----키보드 올라오면 스위치 오프
            if (e.KeyCode == Keys.Left) {

                bl_on = 0;
                ul_on = 0;

            }
            if (e.KeyCode == Keys.Up) {
                
                bu_on = 0; uu_on = 0;
               
            }
            if (e.KeyCode == Keys.Down) {

             
                bd_on = 0; ud_on = 0;
                
            }
            if (e.KeyCode == Keys.Z)
                {
                if (chars[0].img == uz0)
                    chars[0].img = u0;
                if (chars[0].img == luz0)
                    chars[0].img = ul0;
                if (chars[0].img == urz0)
                    chars[0].img = ur0;
                if (chars[0].img == rz0)
                    chars[0].img = r0;
                if (chars[0].img == rdz0)
                    chars[0].img = dr0;
                if (chars[0].img == lz0)
                    chars[0].img = l0;
                if (chars[0].img == dlz0)
                    chars[0].img = dl0;
                if (chars[0].img == dz0)
                    chars[0].img = d0;

                if (chars[0].img == xuz0)
                    chars[0].img = xu0;
                if (chars[0].img == xluz0)
                    chars[0].img = xul0;
                if (chars[0].img == xurz0)
                    chars[0].img = xur0;
                if (chars[0].img == xrz0)
                    chars[0].img = xr0;
                if (chars[0].img == xrdz0)
                    chars[0].img = xdr0;
                if (chars[0].img == xlz0)
                    chars[0].img = xl0;
                if (chars[0].img == xdlz0)
                    chars[0].img = xdl0;
                if (chars[0].img == xdz0)
                    chars[0].img = xd0;
            }

            if(e.KeyCode==Keys.Space)
            {
                if (chars[0].img == au0)
                    chars[0].img = xu0;
                if (chars[0].img == alu0)
                    chars[0].img = xul0;
                if (chars[0].img == aru0)
                    chars[0].img = xur0;
                if (chars[0].img == ar0)
                    chars[0].img = xr0;
                if (chars[0].img == ard0)
                    chars[0].img = xdr0;
                if (chars[0].img == adl0)
                    chars[0].img = xdl0;
                if (chars[0].img == al0)
                    chars[0].img = xl0;
                if (chars[0].img == ad0)
                    chars[0].img = xd0;

            }
        }      
    }
}
