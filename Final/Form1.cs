namespace Final
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            //************************************* Clear ************************************************//
            ImgDraw.CreateGraphics().Clear(Color.White);
        }

        private void btn_print_Click(object sender, EventArgs e)
        {
            //************************************** Clear ************************************************//
            ImgDraw.CreateGraphics().Clear(Color.LightSkyBlue);
            //**************** Width & Height **************//
            int imgX = ImgDraw.Width;
            int imgY = ImgDraw.Height;

            //*********************************** Background **********************************************//
            //**************** Polygon "Mountains" **************//
            Point M1 = new Point(0, (imgY / 6) * 4);
            Point M2 = new Point((imgX / 8) * 2, (imgY / 6) * 3);
            Point M3 = new Point((imgX / (8 * 2)) * 5, (imgY / (6 * 2)) * 7);
            Point M4 = new Point((imgX / (8 * 3)) * 11, (imgY / (6 * 2)) * 5);
            Point M5 = new Point((imgX / (8 * 3)) * 16, (imgY / 6) * 4);
            Point M6 = new Point((imgX / 8) * 7, (imgY / (6 * 2)) * 7);
            Point M7 = new Point(imgX, (imgY / 6) * 4);
            Point M8 = new Point(imgX, imgY);
            Point M9 = new Point(0, imgY);
            //List Point 
            Point[] AllPiont = { M1, M2, M3, M4, M5, M6, M7, M8, M9 };
            //Fill
            ImgDraw.CreateGraphics().FillPolygon(Brushes.LightGreen, AllPiont);
            ImgDraw.CreateGraphics().DrawPolygon(Pens.DarkGreen, AllPiont);

            //**************** Rectangle Street **************//
            ImgDraw.CreateGraphics().FillRectangle(Brushes.Gray, 0, (imgY / (6 * 3)) * 13, imgX, (imgY / (6*6))*7);
            ImgDraw.CreateGraphics().RotateTransform(90);


            //**************** Street Line **************//
            //Pen of Line
            Pen p = new Pen(Color.LightGray, imgY / 40);
            //y of line
            int y = ((imgY / (6 * 3)) * 13) + ((imgY / (6 * 6)) * 7)/2;
            //Point Line
            Point l1 = new Point(0, y);
            Point l2 = new Point(imgX, y);
            //Draw Line
            ImgDraw.CreateGraphics().DrawLine(p, l1, l2);

            //**************************************** Fans *************************************************//
            //**************** Fan Lines **************//
            //pen of Fan Line
            Graphics fan = ImgDraw.CreateGraphics();
            Pen Fan_line = new Pen(Color.Gray, imgY / 60);
            Pen Fan_line2 = new Pen(Color.Silver, imgY / 130);
            //Point of fan Line
            Point Fan_point1 = new Point(imgX / (8 * 4) * 3, imgY / (6 * 2) * 3);
            Point Fan_point2 = new Point(imgX / (8 * 4) * 3, imgY / (6 * 3) * 12);
            //Draw fan Line
            fan.DrawLine(Fan_line, Fan_point1, Fan_point2);
            fan.DrawLine(Fan_line2, Fan_point1, Fan_point2);

            //**************** Fans **************//
            //point of fans 1
            Point f1_1 = new Point(imgX / (8 * 4) * 3 - 1, imgY / (6 * 2) * 3 + 5);
            Point f1_2 = new Point(imgX / (8 * 4) * 3, imgY / 6);
            Point f1_3 = new Point((imgX / (8 * 4) * 5) - imgX / 30, imgY / (6 * 4));
            Point f1_4 = new Point(imgX / (8 * 4) * 3 + imgX / 50, imgY / 6 + 2);
            //List of Fan
            Point[] All_fan1 = { f1_1, f1_2, f1_3, f1_4 };
            //Draw fan
            fan.FillPolygon(Brushes.LightCoral, All_fan1);
            fan.DrawPolygon(Pens.Brown, All_fan1);

            //point of fans 2
            Point f2_1 = new Point(imgX / (8 * 4) * 3 - 1, imgY / (6 * 2) * 3 + 5);
            Point f2_2 = new Point(imgX / (8 * 4) * 4, imgY / (6 * 3) * 5);
            Point f2_3 = new Point((imgX / (8 * 2) * 3), imgY / (6 * 4) * 10);
            Point f2_4 = new Point(imgX / 8, imgY / (6 * 3) * 6);
            //List of Fan
            Point[] All_fan2 = { f2_1, f2_2, f2_3, f2_4 };
            //Draw fan
            fan.FillPolygon(Brushes.LightCoral, All_fan2);
            fan.DrawPolygon(Pens.Brown, All_fan2);

            //point of fans 3
            Point f3_1 = new Point(imgX / (8 * 4) * 3 - 1, imgY / (6 * 2) * 3 + 5);
            Point f3_2 = new Point(imgX / (8 * 2), imgY / (6 * 4) * 6);
            Point f3_3 = new Point(-imgX / 30, imgY / (6 * 3) * 6);
            Point f3_4 = new Point(imgX / (8 * 2) * 1, imgY / (6 * 12) * 22);
            //List of Fan
            Point[] All_fan3 = { f3_1, f3_2, f3_3, f3_4 };
            //Draw fan
            fan.FillPolygon(Brushes.LightCoral, All_fan3);
            fan.DrawPolygon(Pens.Brown, All_fan3);

            //*********** Translate ***********//
            // st
            fan.TranslateTransform(imgX / (8 * 2) * 5, imgY/(6*2));
            fan.ScaleTransform(0.7f, 0.7f);
            //Draw fan Line
            fan.DrawLine(Fan_line, Fan_point1, Fan_point2);
            fan.DrawLine(Fan_line2, Fan_point1, Fan_point2);

            //Draw fan1
            fan.FillPolygon(Brushes.LightCoral, All_fan1);
            fan.DrawPolygon(Pens.Brown, All_fan1);
            //Draw fan2
            fan.FillPolygon(Brushes.LightCoral, All_fan2);
            fan.DrawPolygon(Pens.Brown, All_fan2);
            //Draw fan3
            fan.FillPolygon(Brushes.LightCoral, All_fan3);
            fan.DrawPolygon(Pens.Brown, All_fan3);

            // ed
            fan.TranslateTransform(imgX / (8 * 2) * 4, -imgY/6);
            fan.ScaleTransform(1.58f, 1.58f);
            //Draw fan Line
            fan.DrawLine(Fan_line, Fan_point1, Fan_point2);
            fan.DrawLine(Fan_line2, Fan_point1, Fan_point2);

            //Draw fan1
            fan.FillPolygon(Brushes.LightCoral, All_fan1);
            fan.DrawPolygon(Pens.Brown, All_fan1);
            //Draw fan2
            fan.FillPolygon(Brushes.LightCoral, All_fan2);
            fan.DrawPolygon(Pens.Brown, All_fan2);
            //Draw fan3
            fan.FillPolygon(Brushes.LightCoral, All_fan3);
            fan.DrawPolygon(Pens.Brown, All_fan3);


            //****************************************** Car ************************************************//
            //**************** Car cricle **************//
            //pen car
            Pen p_cricle = new Pen(Color.DarkSlateGray, imgX / 160);
            int x_car1 = imgX / (8 * 4) * 15 + imgX/160;
            int y_car = (imgY / (6 * 3) * 14) + ((imgX / (8 * 2)) / 2);
            int x_car2 = (imgX / (8 * 4) * 15) + (imgX / (8 * 2) -imgX/160);
            //p2
            int car_len = x_car2 - x_car1;
            int x_car_p2_1 = (x_car1 + x_car2) / 2;
            int y_car_p2_2 = y_car - (car_len) / 2;
            int y_car_p2_3 = y_car + (car_len) / 2;

            //circle
            //graphics
            Graphics Car_cir = ImgDraw.CreateGraphics();
            Car_cir.DrawEllipse(p_cricle, imgX / (8 * 4) * 15 - 2, imgY / (6 * 3) * 14 - 2, imgX / (8 * 2) + 4, imgX / (8 * 2) + 4);
            Car_cir.FillEllipse(Brushes.MintCream, imgX / (8 * 4) * 15, imgY / (6 * 3) * 14, imgX / (8 * 2), imgX / (8 * 2));

            //line car
            Car_cir.DrawLine(p_cricle, x_car1 - imgX / 160, y_car, x_car2 + imgX / 160, y_car);
            Car_cir.DrawLine(p_cricle, x_car_p2_1, y_car_p2_2 , x_car_p2_1, y_car_p2_3 + imgY/60);
            Car_cir.DrawLine(p_cricle, x_car1, y_car_p2_2, x_car2, y_car_p2_3);
            Car_cir.DrawLine(p_cricle, x_car2, y_car_p2_2, x_car1, y_car_p2_3);




            //translate
            Car_cir.TranslateTransform(-imgX / 8, 0);
            Car_cir.DrawEllipse(p_cricle, imgX / (8 * 4) * 15 - 2, imgY / (6 * 3) * 14 - 2, imgX / (8 * 2) + 4, imgX / (8 * 2) + 4);
            Car_cir.FillEllipse(Brushes.MintCream, imgX / (8 * 4) * 15, imgY / (6 * 3) * 14, imgX / (8 * 2), imgX / (8 * 2));
            Car_cir.DrawLine(p_cricle, x_car1 - imgX / 160, y_car, x_car2 + imgX / 160, y_car);
            Car_cir.DrawLine(p_cricle, x_car_p2_1, y_car_p2_2, x_car_p2_1, y_car_p2_3 + imgY / 60);
            Car_cir.DrawLine(p_cricle, x_car1, y_car_p2_2, x_car2, y_car_p2_3);
            Car_cir.DrawLine(p_cricle, x_car2, y_car_p2_2, x_car1, y_car_p2_3);



            //**************** Car body **************//
            Point c1 = new Point((imgX / (8 * 2)) * 5, (imgY / (6 * 4)) * 20);
            Point c2 = new Point((imgX / (8 * 2)) * 5, (imgY / (6 * 4)) * 17);
            Point c3 = new Point((imgX / (8 * 3)) * 8, (imgY / (6 * 4)) * 17);
            Point c4 = new Point((imgX / (8 * 3)) * 8, (imgY / (6 * 5)) * 19);
            Point c5 = new Point((imgX / (8 * 3)) * 11, (imgY / (6 * 5)) * 19);
            Point c6 = new Point((imgX / (8 * 3)) * 11, (imgY / (6 * 4)) * 17);
            Point c7 = new Point((imgX / (8 * 3)) * 14, (imgY / (6 * 4)) * 17);
            Point c8 = new Point((imgX / (8 * 3)) * 14, (imgY / (6 * 4)) * 20);
            //List Point 
            Point[] AllC = { c1, c2, c3, c4, c5, c6, c7, c8 };
            //Fill
            ImgDraw.CreateGraphics().FillPolygon(Brushes.Salmon, AllC);
            ImgDraw.CreateGraphics().DrawPolygon(Pens.Maroon, AllC);

            //******************************************* Sun ***********************************************//
            //**************** Sun Lines **************//
            //pen for Lines
            Pen sun_line = new Pen(Color.Gold, imgY / 150);
            //y of sun Lines
            int Sun_y = (((imgY / 24) * 2)) + ((imgX / 8) + 4) / 2;

            int x_sun_l1 = ((imgX / (8 * 4)) * 25) - 17;
            int y_sun_l1 = Sun_y;
            int x_sun_l2 = (((imgX / (8 * 4)) * 25) - 3) + (imgX / 8 + 17);
            int y_sun_l2 = Sun_y;


            //p 1
            Point Sp1 = new Point(x_sun_l1 -imgX/50, y_sun_l1);
            Point Sp2 = new Point(x_sun_l2 + imgX/50, y_sun_l2);
            //Draw Sun Lines
            Graphics g_sunline = ImgDraw.CreateGraphics();
            //g_sunline.DrawLine(sun_line, xx1,yy1, xx2, yy2);
            g_sunline.DrawLine(sun_line, Sp1, Sp2);

            int len_l = x_sun_l2 - x_sun_l1;
            int x_p2 =(x_sun_l1+ x_sun_l2)/2;
            int y_p2 = y_sun_l1 - (len_l /2) ;
            int y_p2_1 = (y_sun_l1 )+ (len_l /2);


            //p 2
            Point Sp1_1 = new Point(x_p2, y_p2-imgY/30);
            Point Sp2_1 = new Point(x_p2, y_p2_1 + imgY/30);
            //Draw Sun Lines

            g_sunline.DrawLine(sun_line, Sp1_1, Sp2_1);

            //p 3
            int x_c = (x_sun_l2 - x_sun_l1) / 2;
            int y_c = (y_p2_1 - y_p2) / 2;


            Point Sp3_1 = new Point(x_sun_l1, y_p2_1);
            Point Sp3_2 = new Point(x_sun_l2, y_p2);
            //Draw Sun Lines

            g_sunline.DrawLine(sun_line, Sp3_1, Sp3_2);

            //p 3
 
            Point Sp4_1 = new Point(x_sun_l1, y_p2);
            Point Sp4_2 = new Point(x_sun_l2, y_p2_1);
            //Draw Sun Lines

            g_sunline.DrawLine(sun_line, Sp4_1, Sp4_2);



            //**************** Sun Fill **************//
            ImgDraw.CreateGraphics().FillEllipse(Brushes.LightSkyBlue, (imgX / (8 * 4)) * 25 -imgX/80, (imgY / 24) * 2 -imgY/50, imgX / (8*8)*10, imgX / (8 *8 ) * 10);
            //Sun Out Line
            ImgDraw.CreateGraphics().FillEllipse(Brushes.Gold, ((imgX / (8 * 4)) * 25) - 2, ((imgY / 24) * 2) - 2, (imgX / 8) + 4, (imgX / 8) + 4);
            //Sun Fill
            ImgDraw.CreateGraphics().FillEllipse(Brushes.LightYellow, (imgX / (8 * 4)) * 25, (imgY / 24) * 2, imgX / 8, imgX / 8);



        }
    }
}