using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using TowerDefense.Core;
using TowerDefense.Core.Abstract;
using TowerDefense.Core.Interfaces;
using TowerDefense.Core.Managers;
using TowerDefense.Core.Towers;

// This project is developed as part of Sakarya University NDP Course.
// Student: Hagar Mohammed
// Student No: B241200553
// Kule savunma oyunu - Tower Defense Game


namespace TowerDefense

{
    public partial class Form1 : Form
    {
        private void EnableDoubleBuffering(Control control)
        {
            typeof(Control).GetProperty("DoubleBuffered",
                System.Reflection.BindingFlags.NonPublic |
                System.Reflection.BindingFlags.Instance)
                ?.SetValue(control, true, null);
        }

        public Form1()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            EnableDoubleBuffering(GamePanel);


            gameManager = new GameManager(300, 20, 5);
            gameManager.Yol.GuncelleYol(GamePanel.Width, GamePanel.Height);
            GuncelleUstPanel();

            GamePanel.MouseDown += GamePanel_MouseDown;
            GamePanel.MouseMove += GamePanel_MouseMove;
            GamePanel.MouseLeave += GamePanel_MouseLeave;

            GamePanel.Resize += GamePanel_Resize;


            attackTimer = new Timer();
            attackTimer.Interval = 200;
            attackTimer.Tick += AttackTimer_Tick;
            attackTimer.Start();

            spawnTimer = new Timer();
            spawnTimer.Interval = 1000; // enemy spawn interval
            spawnTimer.Tick += SpawnTimer_Tick;
            spawnTimer.Start();


        }

        private bool oyunBitti = false;

        private void GamePanel_MouseMove(object sender, MouseEventArgs e)
        {
            // snap mouse position to grid
            int x = (e.X / HUCRE) * HUCRE;
            int y = (e.Y / HUCRE) * HUCRE;
            Point hucreKonum = new Point(x, y);

            // check if mouse is over a tower
            var kule = kuleler.FirstOrDefault(k => k.Konum == hucreKonum);

            if (hoverKule != kule)
            {
                hoverKule = kule;
                GamePanel.Invalidate(); // redraw only when changed
            }
        }
        private void GamePanel_MouseLeave(object sender, EventArgs e)
        {
            hoverKule = null;
            GamePanel.Invalidate();
        }


        private void OyunBitir(string mesaj)
        {
            oyunBitti = true;

            gameTimer.Stop();
            spawnTimer.Stop();
            attackTimer.Stop();

            DialogResult result = MessageBox.Show(
                mesaj + "\n\nRestart the game?",
                "Game Over",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Information
            );

            if (result == DialogResult.Yes)
            {
                Application.Restart();   // restart full game 
            }
            else
            {
                Application.Exit();
            }
        }



        private void DusmanlariHareketEttirFormda()
        {
            var yol = gameManager.Yol.Noktalar;
            if (yol.Count < 2) return;


            foreach (var d in gameManager.Dusmanlar)
            {
                if (d.IsDead) continue;

                if (d.HedefIndex >= yol.Count)
                {
                    d.Escaped = true;
                    d.Health = 0;
                    gameManager.HasarAl(1);
                    GuncelleUstPanel();

                    if (gameManager.Can <= 0)
                    {
                        OyunBitir(
                            $"Game Over!\n" +
                            $"Skor: {gameManager.Skor}\n" +
                            $"Dalga: {gameManager.MevcutDalga}/{gameManager.ToplamDalga}"
                        );
                        return;
                    }


                    continue;

                }


                Point hedef = yol[d.HedefIndex];

                int dx = hedef.X - d.X;
                int dy = hedef.Y - d.Y;


                if (Math.Abs(dx) <= d.Speed && Math.Abs(dy) <= d.Speed)
                {
                    d.X = hedef.X;
                    d.Y = hedef.Y;
                    d.HedefIndex++;
                    continue;
                }

                if (dx != 0) d.X += Math.Sign(dx) * d.Speed;
                if (dy != 0) d.Y += Math.Sign(dy) * d.Speed;
            }
        }

        // Update top panel UI from GameManager

        private void GuncelleUstPanel()
        {
            lblAltin.Text = $"Altın: {gameManager.Altin}";
            lblCan.Text = $"Can: {gameManager.Can}";
            lblDalga.Text = $"Dalga: {gameManager.MevcutDalga}/{gameManager.ToplamDalga}";
            lblSkor.Text = $"Skor: {gameManager.Skor}";
        }



        private Timer attackTimer;

        private Timer spawnTimer;
        private int dusmanSayaci = 0;
        private int dusmanSayisiBuDalga = 5;

        private bool dalgaBitti = false;



        // game logic manager
        private GameManager gameManager;

        // selected tower type
        private KuleTuru seciliKule = KuleTuru.Ok;

        private YerlesikKule hoverKule = null;


        // simple placed tower record
        private class YerlesikKule
        {
            public Kule Kule { get; set; }
            public Point Konum { get; set; } // left-top position in panel
        }

        private readonly List<YerlesikKule> kuleler = new List<YerlesikKule>();
        private YerlesikKule seciliYerlesikKule = null;


        // grid cell size
        private const int HUCRE = 40;

        private void SeciliKuleDegistir(KuleTuru tur)
        {
            seciliKule = tur;
        }

        private void lblOkName_Click(object sender, EventArgs e)
        {
            SeciliKuleDegistir(KuleTuru.Ok);

        }

        private void lblTopName_Click(object sender, EventArgs e)
        {
            SeciliKuleDegistir(KuleTuru.Top);
        }

        private void lblBuyuName_Click(object sender, EventArgs e)
        {
            SeciliKuleDegistir(KuleTuru.Buyu);
        }

        private void picTop_Click(object sender, EventArgs e)
        {
            SeciliKuleDegistir(KuleTuru.Top);
        }

        private void topPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblLazerComingSoon_Click(object sender, EventArgs e)
        {

        }

        private void lblLazerCost_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
            gameTimer.Start();
            GamePanel.Invalidate();
        }


        private void picOk_Click(object sender, EventArgs e)
        {
            SeciliKuleDegistir(KuleTuru.Ok);
        }

        private void pnlOkKulesi_Click(object sender, EventArgs e)
        {
            SeciliKuleDegistir(KuleTuru.Ok);
        }

        private void panelBuyu_Paint(object sender, PaintEventArgs e)
        {
            SeciliKuleDegistir(KuleTuru.Buyu);
        }

        private void pnlBuyuKulesi_Click(object sender, EventArgs e)
        {
            SeciliKuleDegistir(KuleTuru.Buyu);
        }

        private void pnlTopKulesi_Click(object sender, EventArgs e)
        {
            SeciliKuleDegistir(KuleTuru.Top);
        }


        private void KuleEkle(Point konum)
        {
            // snap to grid
            int x = (konum.X / HUCRE) * HUCRE;
            int y = (konum.Y / HUCRE) * HUCRE;
            Point hucreKonum = new Point(x, y);

            // prevent placing towers on the path
            if (YolUzerindeMi(hucreKonum))
            {
                MessageBox.Show("You cannot place a tower on the path!");
                return;
            }

            // check overlap
            foreach (var k in kuleler)
            {
                if (k.Konum == hucreKonum)
                {
                    MessageBox.Show("Bu alanda zaten bir kule var!");
                    return;
                }
            }


            Kule yeniKule = null;
            int maliyet = 0;

            switch (seciliKule)
            {
                case KuleTuru.Ok:
                    yeniKule = new OkKulesi();
                    maliyet = 100;
                    break;
                case KuleTuru.Buyu:
                    yeniKule = new BuyuKulesi();
                    maliyet = 200;
                    break;
                case KuleTuru.Top:
                    yeniKule = new TopKulesi();
                    maliyet = 250;
                    break;
                default:
                    return;
            }

            if (!gameManager.AltinHarca(maliyet))
            {
                MessageBox.Show("Yeterli altın yok!");
                return;
            }

            GuncelleUstPanel();
            yeniKule.Konum = hucreKonum;

            var yerlesik = new YerlesikKule
            {
                Kule = yeniKule,
                Konum = hucreKonum
            };

            kuleler.Add(yerlesik);
            seciliYerlesikKule = yerlesik;


            GamePanel.Invalidate();
        }

        // checks if a grid cell overlaps with the path - yol kontrolü
        private bool YolUzerindeMi(Point hucreKonum)
        {
            const int yolGenislik = 0; // path width

            for (int i = 0; i < gameManager.Yol.Noktalar.Count - 1; i++)
            {
                Point p1 = gameManager.Yol.Noktalar[i];
                Point p2 = gameManager.Yol.Noktalar[i + 1];

                Rectangle yolRect;

                // horizontal path
                if (p1.Y == p2.Y)
                {
                    yolRect = new Rectangle(
                        Math.Min(p1.X, p2.X),
                        p1.Y - yolGenislik / 2,
                        Math.Abs(p1.X - p2.X),
                        yolGenislik
                    );
                }
                // vertical path
                else
                {
                    yolRect = new Rectangle(
                        p1.X - yolGenislik / 2,
                        Math.Min(p1.Y, p2.Y),
                        yolGenislik,
                        Math.Abs(p1.Y - p2.Y)
                    );
                }

                Rectangle kuleRect = new Rectangle(
                    hucreKonum.X,
                    hucreKonum.Y,
                    HUCRE,
                    HUCRE
                );

                if (yolRect.IntersectsWith(kuleRect))
                    return true;
            }

            return false;
        }


        private void GamePanel_MouseClick(object sender, MouseEventArgs e)
        {
            // only left click places a tower
            if (e.Button != MouseButtons.Left)
                return;

            if (seciliKule == KuleTuru.Yok)
                return;

            KuleEkle(e.Location);
        }



        private void GamePanel_Resize(object sender, EventArgs e)
        {
            // rebuild path according to new panel size
            gameManager.Yol.GuncelleYol(GamePanel.Width, GamePanel.Height);

            // reset enemies to start of path after resize
            if (gameManager.Yol.Noktalar.Count > 0)
            {
                Point start = gameManager.Yol.Noktalar[0];

                foreach (var d in gameManager.Dusmanlar)
                {
                    d.X = start.X;
                    d.Y = start.Y;
                    d.HedefIndex = 0;
                }
            }

            GamePanel.Invalidate();
        }


        private void GamePanel_Paint(object sender, PaintEventArgs e)
        {
            // draw background
            e.Graphics.DrawImage(
                Properties.Resources.BgGrass,
                new Rectangle(0, 0, GamePanel.Width, GamePanel.Height)
            );

            var yolNoktalar = gameManager.Yol.Noktalar;

            if (yolNoktalar.Count >= 2)
            {
                using (var pen = new Pen(Color.SandyBrown, 10)
)
                {
                    e.Graphics.SmoothingMode =
                        System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

                    e.Graphics.DrawLines(pen, yolNoktalar.ToArray());
                }
            }



            // draw towers
            foreach (var yk in kuleler)
            {
                Image img = null;

                if (yk.Kule is OkKulesi)
                    img = Properties.Resources.OkKulesi;
                else if (yk.Kule is BuyuKulesi)
                    img = Properties.Resources.BuyuKulesi;
                else if (yk.Kule is TopKulesi)
                    img = Properties.Resources.TopKulesi;

                if (img != null)
                {
                    e.Graphics.DrawImage(
                        img,
                        yk.Konum.X,
                        yk.Konum.Y,
                        HUCRE,
                        HUCRE
                    );
                }
            }

            // draw range when hovering over a tower
            if (hoverKule != null)
            {
                int range = hoverKule.Kule.Range;

                int centerX = hoverKule.Konum.X + HUCRE / 2;
                int centerY = hoverKule.Konum.Y + HUCRE / 2;

                using (Pen pen = new Pen(Color.FromArgb(120, Color.Blue), 2))
                {
                    e.Graphics.DrawEllipse(
                        pen,
                        centerX - range,
                        centerY - range,
                        range * 2,
                        range * 2
                    );
                }
            }


            // draw enemies with hit effect
            foreach (var d in gameManager.Dusmanlar)
            {
                if (d.IsDead) continue;

                int enemySize = 32;

                // if enemy was recently hit
                if (d.IsHit && (DateTime.Now - d.HitTime).TotalMilliseconds < 150)
                {
                    // hit flash effect red
                    e.Graphics.DrawImage(
                        Properties.Resources.EnemyHit,
                        d.X - enemySize / 2,
                        d.Y - enemySize / 2,
                        enemySize,
                        enemySize
                    );
                }
                else
                {
                    // normal enemy drawing
                    e.Graphics.DrawImage(
                        Properties.Resources.Enemy,
                        d.X - enemySize / 2,
                        d.Y - enemySize / 2,
                        enemySize,
                        enemySize
                    );

                    // reset hit flag
                    d.IsHit = false;
                }
            }

        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            DusmanlariHareketEttirFormda();

            // dalga completion logic 

            if (dalgaBitti && gameManager.Dusmanlar.Count == 0)
            {
                // if all dalga is completed end game 
                if (gameManager.MevcutDalga >= gameManager.ToplamDalga)
                {
                    OyunBitir(
                        $"🎉 Tebrikler!\n" +
                        $"Skor: {gameManager.Skor}\n" 
                    );
                    return;
                }


                // else Move to next dalga
                gameManager.SonrakiDalga();
                GuncelleUstPanel();

                lblWaveMessage.Text = $"Dalga {gameManager.MevcutDalga} Başlıyor!";
                lblWaveMessage.Visible = true;
                waveMessageTimer.Start();

                // prepare next dalga
                dusmanSayaci = 0;
                dusmanSayisiBuDalga += 3;
                dalgaBitti = false;

                spawnTimer.Start();
            }
            if (gameManager.Dusmanlar.Count > 0)
                GamePanel.Invalidate();
        }


        private void AttackTimer_Tick(object sender, EventArgs e)
        {
            // towers attack enemies
            foreach (var yk in kuleler)
            {
                yk.Kule.Saldir(gameManager.Dusmanlar);
            }

            // get dead enemies snapshot
            var deadOnes = gameManager.Dusmanlar
                .Where(d => d.IsDead)
                .ToList();

            // reward only killed enemies 
            foreach (var d in deadOnes)
            {
                if (!d.IsDying)
                {
                    d.IsDying = true;
                    d.DeathTime = DateTime.Now;
                    continue;
                }

                if ((DateTime.Now - d.DeathTime).TotalMilliseconds > 150)
                {
                    if (!d.Escaped)
                    {
                        gameManager.SkorEkle(10);
                        gameManager.AltinEkle(20);
                    }

                    gameManager.Dusmanlar.Remove(d);
                }
            }


            GuncelleUstPanel();

        }

        private void SpawnTimer_Tick(object sender, EventArgs e)
        {
            // all enemies spawned for this dalga
            if (dusmanSayaci >= dusmanSayisiBuDalga)
            {
                spawnTimer.Stop();
                dalgaBitti = true;
                return;
            }

            // yeni düşman oluştur
            var yol = gameManager.Yol.Noktalar;
            if (yol.Count == 0) return;

            int spawnSpacing = 20; // distance between enemies

            var d = new TowerDefense.Core.Entities.Dusman(
     health: 100 + (gameManager.MevcutDalga * 20),
     speed: 2 + gameManager.MevcutDalga / 2,  // rising speed per dalga
     startX: yol[0].X - dusmanSayaci * spawnSpacing,
     startY: yol[0].Y
 );



            gameManager.Dusmanlar.Add(d);
            dusmanSayaci++;
        }


        private void picBuyu_Click(object sender, EventArgs e)
        {
            SeciliKuleDegistir(KuleTuru.Buyu);
        }

        private void lblBuyuCost_Click(object sender, EventArgs e)
        {
            SeciliKuleDegistir(KuleTuru.Buyu);
        }

        private void lblTopCost_Click(object sender, EventArgs e)
        {
            SeciliKuleDegistir(KuleTuru.Top);
        }

        private void lblOkPrice_Click(object sender, EventArgs e)
        {
            SeciliKuleDegistir(KuleTuru.Ok);
        }
        private void GamePanel_MouseDown(object sender, MouseEventArgs e)
        {
            // right click for tower upgrade 
            if (e.Button != MouseButtons.Right)
                return;

            // Snap to grid
            int x = (e.X / HUCRE) * HUCRE;
            int y = (e.Y / HUCRE) * HUCRE;
            Point hucreKonum = new Point(x, y);

            // find tower on selected grid cell
            var hedefKule = kuleler.FirstOrDefault(k => k.Konum == hucreKonum);

            if (hedefKule == null)
                return;

            // check if tower is upgradeable
            if (hedefKule.Kule is IYukseltilebilir yukseltilebilir)
            {
                int upgradeCost = 50; 

                if (!gameManager.AltinHarca(upgradeCost))
                {
                    MessageBox.Show("Yeterli altın yok!");
                    return;
                }

                yukseltilebilir.Yukselt();
                GuncelleUstPanel();
                GamePanel.Invalidate();
            }
        }


        private void pnlOkKulesi_Paint(object sender, PaintEventArgs e)
        {
            SeciliKuleDegistir(KuleTuru.Ok);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            SeciliKuleDegistir(KuleTuru.Ok);
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            SeciliKuleDegistir(KuleTuru.Top);
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            SeciliKuleDegistir(KuleTuru.Buyu);
        }

        private void panelTop_Paint(object sender, PaintEventArgs e)
        {
            SeciliKuleDegistir(KuleTuru.Top);
        }

        private void waveMessageTimer_Tick(object sender, EventArgs e)
        {
            lblWaveMessage.Visible = false;
            waveMessageTimer.Stop();
        }

        private void lblWaveMessage_Click(object sender, EventArgs e)
        {

        }
    }


}

