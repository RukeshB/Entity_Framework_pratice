//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace EnityFramework
//{
//    class printpratice2
//    {
//        public void print_ticket(string service)
//        {

//            int pos = Array.IndexOf(x_service_print_key, service);

//            // Nếu phím bấm tồn tại để kích hoạt in phiếu
//            if (pos > -1)
//            {
//                string printer_code = "1";
//                string service_code = x_service_code[pos];
//                string priority = x_priority[pos];
//                string number = (Convert.ToInt32(x_serial_number[pos]) + 1).ToString().PadLeft(x_serial_number[pos].Length, '0');

//                // Lấy số cuối cùng của dịch vụ cộng thêm 1 và gán cho biến number
//                string sql = "SELECT number FROM current WHERE service_code = '" + x_service_code[pos] + "' ORDER BY id DESC LIMIT 1";
//                MySqlCommand cmd = new MySqlCommand(sql, connection);
//                cmd.CommandTimeout = 60;
//                DbDataReader reader = cmd.ExecuteReader();
//                if (reader.HasRows)
//                {
//                    while (reader.Read())
//                    {
//                        number = (Convert.ToInt32(reader.GetValue(reader.GetOrdinal("number"))) + 1).ToString().PadLeft(x_serial_number[pos].Length, '0');
//                    }
//                }
//                reader.Close();

//                // Insert vào database số mới.
//                sql = "INSERT INTO current(printer_code, service_code, priority, number) VALUES('" + printer_code + "','" + service_code + "'," + priority + ",'" + number + "')";
//                cmd = new MySqlCommand(sql, connection);
//                int rowCount = cmd.ExecuteNonQuery();

//                // Cập nhật ra màn hình
//                this.Controls.Find("lbl_" + x_service_code[pos].ToString(), true).FirstOrDefault().Text = number;


//                // In phiếu ra giấy
//                printTicket.PrintPage += (sender, e) =>
//                {
//                    e.Graphics.Clear(Color.White);
//                    // Khai báo thông số text
//                    // -- Màu sắc
//                    SolidBrush drawBrush = new SolidBrush(Color.Black);
//                    // -- Font chữ, size chữ
//                    Font drawFont1 = new System.Drawing.Font("Arial", 12, FontStyle.Bold);
//                    Font drawFont2 = new System.Drawing.Font("Arial", 60, FontStyle.Bold);
//                    Font drawFont3 = new System.Drawing.Font("Arial", 16, FontStyle.Bold);
//                    Font drawFont4 = new System.Drawing.Font("Arial", 10, FontStyle.Italic | FontStyle.Bold);
//                    // -- Căn giữa
//                    StringFormat drawFormat = new StringFormat();
//                    drawFormat.Alignment = StringAlignment.Center;

//                    // Logo
//                    Image imgLogo = QMSBUTTON.Properties.Resources.p_logo;
//                    e.Graphics.DrawImage(imgLogo, 20, 0, 280, 24);
//                    // Khoa khám bệnh
//                    RectangleF recAtZero = new RectangleF(0, 25, e.PageBounds.Width, e.PageBounds.Height);
//                    e.Graphics.DrawString("KHOA KHÁM BỆNH", drawFont1, drawBrush, recAtZero, drawFormat);
//                    // Số thứ tự
//                    recAtZero = new RectangleF(0, 50, e.PageBounds.Width, e.PageBounds.Height);
//                    e.Graphics.DrawString(number, drawFont2, drawBrush, recAtZero, drawFormat);
//                    // Tên dịch vụ
//                    recAtZero = new RectangleF(0, 150, e.PageBounds.Width, e.PageBounds.Height);
//                    e.Graphics.DrawString(x_service_name[pos], drawFont3, drawBrush, recAtZero, drawFormat);
//                    // Phiếu in lúc
//                    recAtZero = new RectangleF(0, 180, e.PageBounds.Width, e.PageBounds.Height);
//                    e.Graphics.DrawString("Phiếu in lúc: " + DateTime.Now.ToString("HH:mm:ss - dd/MM/yyyy"), drawFont1, drawBrush, recAtZero, drawFormat);
//                    // Phiếu chỉ có giá trị trong ngày!
//                    recAtZero = new RectangleF(0, 200, e.PageBounds.Width, e.PageBounds.Height);
//                    e.Graphics.DrawString("Phiếu chỉ có giá trị trong ngày!", drawFont4, drawBrush, recAtZero, drawFormat);


//                };

//                printTicketDialog.ShowDialog();
//                //printTicket.Print();
//            }
//        }
//    }
//}
