using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppUWPR.Data
{
    public class NewsItem
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public float Price { get; set; }
        public string StrPrice { get; set; }
        public DateTime Timestamp { get; set; }
        public string ImagePath { get; set; }

        public static List<NewsItem> GetList()
        {
            return new List<NewsItem>
            {
                new NewsItem
                {
                    Title = "Điện thoại iPhone 14 Pro Max 128GB",
                    Description = "iPhone 14 Pro Max một siêu phẩm trong giới smartphone được nhà Táo tung ra thị trường vào tháng 09/2022. Máy trang bị con chip Apple A16 Bionic vô cùng mạnh mẽ, đi kèm theo đó là thiết kế hình màn hình mới, hứa hẹn mang lại những trải nghiệm đầy mới mẻ cho người dùng iPhone.",
                    Price = 21990000,
                    StrPrice = "26.990.000 đ",
                    ImagePath = "Images/Iphone/iphone-14-pro-den-1-1.jpg"
                },
                new NewsItem
                {
                    Title = "Điện thoại iPhone 11 64GB",
                    Description = "Apple đã chính thức trình làng bộ 3 siêu phẩm iPhone 11, trong đó phiên bản iPhone 11 64GB có mức giá rẻ nhất nhưng vẫn được nâng cấp mạnh mẽ như iPhone Xr ra mắt trước đó.",
                    Price = 24990000,
                    StrPrice = "11.990.000 đ",
                    ImagePath = "Images/Iphone/iphone-11-trang-1-2-org.jpg"
                },
                new NewsItem
                {
                    Title = "Điện thoại iPhone 14 128GB",
                    Description = "Samsung chính thức trình làng mẫu máy tính bảng có tên Galaxy Tab S7 FE, máy trang bị cấu hình mạnh mẽ, màn hình giải trí siêu lớn và điểm ấn tượng nhất là viên pin siêu khủng được tích hợp bên trong, giúp tăng hiệu suất làm việc nhưng vẫn có tính di động cực cao.",
                    Price = 13990000,
                    StrPrice = "22.490.000 đ",
                    ImagePath = "Images/Iphone/iphone-14-do-1-1.jpg"
                },
                new NewsItem
                {
                    Title = "Điện thoại iPhone 14 Plus 128GB",
                    Description = "Sau nhiều thế hệ điện thoại của Apple thì cái tên “Plus” cũng đã chính thức trở lại vào năm 2022 và xuất hiện trên chiếc iPhone 14 Plus 128GB, nổi trội với ngoại hình bắt trend cùng màn hình kích thước lớn để đem đến không gian hiển thị tốt hơn cùng cấu hình mạnh mẽ không đổi so với bản tiêu chuẩn.",
                    Price = 10990000,
                    StrPrice = "24.990.000 đ",
                    ImagePath = "Images/Iphone/iphone-14-xanh-duong-1-1.jpg"
                },

                new NewsItem
                {
                    Title = "Điện thoại Samsung Galaxy S23 5G 128GB",
                    Description = "Samsung Galaxy S23 có thể xem là cái tên mở màn cho dòng điện thoại cao cấp được nhà Samsung giới thiệu vào dịp đầu năm 2023, kể từ lúc chính thức ra mắt máy nhận được khá nhiều sự quan tâm với hàng loạt thông tin cấu hình hết sức nổi bật như con chip hàng đầu Qualcomm cùng bộ camera siêu chất lượng.",
                    Price = 21990000,
                    StrPrice = "18.390.000 đ",
                    ImagePath = "Images/Samsung/samsung-galaxy-s23-den-1.jpg"
                },
                new NewsItem
                {
                    Title = "Điện thoại Samsung Galaxy S21 FE 5G (6GB/128GB)",
                    Description = "Samsung Galaxy S21 FE 5G (6GB/128GB) được Samsung ra mắt với dáng dấp thời thượng, cấu hình khỏe, chụp ảnh đẹp với bộ 3 camera chất lượng, thời lượng pin đủ dùng hằng ngày và còn gì nữa? Mời bạn khám phá qua nội dung sau ngay.",
                    Price = 24990000,
                    StrPrice = "10.990.000 đ",
                    ImagePath = "Images/Samsung/samsung-galaxy-s21-fe-xanh-1.jpg"
                },
                new NewsItem
                {
                    Title = "Điện thoại Samsung Galaxy S23 Ultra 5G 256GB",
                    Description = "Cuối cùng thì chiếc điện thoại Samsung Galaxy S23 cũng đã chính thức ra mắt tại sự kiện Galaxy Unpacked vào đầu tháng 2 năm 2023, máy nổi bật với camera 200 MP chất lượng, hiệu năng mạnh mẽ nhờ tích hợp con chip Snapdragon 8 Gen 2 và được trang bị thêm nhiều công nghệ hàng đầu trong giới smartphone.",
                    Price = 13990000,
                    StrPrice = "28.990.000 đ",
                    ImagePath = "Images/Samsung/samsung-galaxy-s23-ultra-xanh-1.jpg"
                },
                new NewsItem
                {
                    Title = "Điện thoại Samsung Galaxy A23 4GB",
                    Description = "Samsung Galaxy A23 4GB sở hữu bộ thông số kỹ thuật khá ấn tượng trong phân khúc, máy có một hiệu năng ổn định, cụm 4 camera thông minh cùng một diện mạo trẻ trung phù hợp cho mọi đối tượng người dùng.",
                    Price = 10990000,
                    StrPrice = "4.990.000 đ",
                    ImagePath = "Images/Samsung/samsung-galaxy-a23-4g-1.jpg"
                }
                ,
                new NewsItem
                {
                    Title = "Điện thoại Samsung Galaxy S20 FE (8GB/256GB)",
                    Description = "Samsung đã giới thiệu đến người dùng thành viên mới của dòng S20 Series đó chính là điện thoại Samsung Galaxy S20 FE. Đây là mẫu flagship cao cấp quy tụ nhiều tính năng mà Samfan yêu thích, hứa hẹn sẽ mang lại trải nghiệm cao cấp của dòng Galaxy S với mức giá dễ tiếp cận hơn.",
                    Price = 21990000,
                    StrPrice = "9.490.000 đ",
                    ImagePath = "Images/Samsung/samsung-galaxy-s20-fan-edition-xanh-la-1-org.jpg"
                },

                new NewsItem
                {
                    Title = "Điện thoại OPPO Reno8 T 5G 256GB",
                    Description = "Tiếp nối sự thành công rực rỡ đến từ các thế hệ trước đó thì chiếc OPPO Reno8 T 5G 256GB cuối cùng đã được giới thiệu chính thức tại Việt Nam, được định hình là dòng sản phẩm thuộc phân khúc tầm trung với camera 108 MP, con chip Snapdragon 695 cùng kiểu dáng thiết kế mặt lưng và màn hình bo cong hết sức nổi bật.",
                    Price = 24990000,
                    StrPrice = "10.990.000 đ",
                    ImagePath = "Images/oppo/oppo-reno8-t-vang-5g-1.jpg"
                },
                new NewsItem
                {
                    Title = "Điện thoại OPPO Reno8 Pro 5G",
                    Description = "OPPO Reno8 Pro 5G là chiếc điện thoại cao cấp được nhà OPPO ra mắt vào thời điểm 09/2022, máy hướng đến sự hoàn thiện cao cấp ở phần thiết kế cùng khả năng quay chụp chuyên nghiệp nhờ trang bị vi xử lý hình ảnh MariSilicon X chuyên dụng.",
                    Price = 13990000,
                    StrPrice = "17.990.000 đ",
                    ImagePath = "Images/oppo/oppo-reno8-pro-xanh-1.jpg"
                },
                new NewsItem
                {
                    Title = "Điện thoại OPPO A55",
                    Description = "OPPO cho ra mắt OPPO A55 4G chiếc smartphone giá rẻ tầm trung có thiết kế đẹp mắt, cấu hình khá ổn, cụm camera chất lượng và dung lượng pin ấn tượng, mang đến một lựa chọn trải nghiệm thú vị vừa túi tiền cho người tiêu dùng.",
                    Price = 21990000,
                    StrPrice = "3.690.000 đ",
                    ImagePath = "Images/oppo/oppo-a55-4g-1-2.jpg"
                },
                new NewsItem
                {
                    Title = "Điện thoại OPPO A16K",
                    Description = "OPPO chính thức trình làng mẫu smartphone giá rẻ - OPPO A16K sở hữu màu sắc thời thượng, viên pin dung lượng cao, cấu hình khỏe, selfie lung linh, một lựa chọn thú vị cho người tiêu dùng.",
                    Price = 10990000,
                    StrPrice = "2.590.000 đ",
                    ImagePath = "Images/oppo/oppo-a16k-den-1-1.jpg"
                },
                new NewsItem
                {
                    Title = "Điện thoại OPPO Find X5 Pro 5G",
                    Description = "OPPO Find X5 Pro 5G có lẽ là cái tên sáng giá được xướng tên trong danh sách điện thoại có thiết kế ấn tượng trong năm 2022. Máy được hãng cho ra mắt với một diện mạo độc lạ chưa từng có, cùng với đó là những nâng cấp về chất lượng ở camera nhờ sự hợp tác với nhà sản xuất máy ảnh Hasselblad. ",
                    Price = 24990000,
                    StrPrice = "24.990.000 đ",
                    ImagePath = "Images/oppo/oppo-find-x5-pro-1-1.jpg"
                },
                new NewsItem
                {
                    Title = "Điện thoại Realme C30s (2GB/32GB)",
                    Description = "Mới đây thì chiếc điện thoại Realme C30s (2GB/32GB) cũng đã chính thức lộ diện đúng như dự kiến của người dùng với bộ thông số kỹ thuật khá ấn tượng cùng mức giá hợp lý. Điều này giúp nâng cao trải nghiệm một cách tốt hơn đối với những dòng sản phẩm thuộc phân khúc giá rẻ.",
                    Price = 13990000,
                    StrPrice = "2.250.000 đ",
                    ImagePath = "Images/Realme/realme-c30s-xanh-2gb-1.jpg"
                },
                new NewsItem
                {
                    Title = "Điện thoại Realme 10",
                    Description = "Realme 10 có thể xem là một trong những mẫu smartphone đáng mong đợi nhất trong dịp đầu năm 2023 với nhiều điểm nổi bật, một số điểm đáng chú ý có thể kể đến như: Tấm nền Super AMOLED, camera siêu độ phân giải 50 MP đi kèm con chip Helio G99 mạnh mẽ.",
                    Price = 10990000,
                    StrPrice = "7.190.000 đ",
                    ImagePath = "Images/Realme/realme-10-xanh-1.jpg"
                },
                new NewsItem
                {
                    Title = "Điện thoại Realme 9 Pro+ 5G",
                    Description = "Realme 9 Pro+ 5G - chiếc smartphone tầm trung của Realme đã được ra mắt, máy có một thiết kế đầy màu sắc, cụm 3 camera với cảm biến IMX766 giúp bạn có được những bức ảnh sinh động.",
                    Price = 10990000,
                    StrPrice = "8.490.000 đ",
                    ImagePath = "Images/Realme/realme-9-pro-plus-1-1.jpg"
                },
                new NewsItem
                {
                    Title = "Điện thoại Realme 8 Pro",
                    Description = "Bên cạnh Realme 8, Realme 8 Pro cũng được giới thiệu đến người dùng với điểm nhấn chính là sự xuất hiện của camera 108 MP siêu nét cùng công nghệ sạc SuperDart 50 W và đi kèm mức giá bán tầm trung rất lý tưởng.",
                    Price = 10990000,
                    StrPrice = "5.790.000 đ",
                    ImagePath = "Images/Realme/realme-8-pro--vang-1-org.jpg"
                },
                new NewsItem
                {
                    Title = "Điện thoại Realme 9 4G",
                    Description = "Realme 9 4G hiện đang là một cái tên được cộng đồng người dùng smartphone hết sức quan tâm và đón nhận, nhờ sở hữu trong mình công nghệ màn hình xịn sò, khả năng chụp ảnh siêu độ phân giải với camera chính 108 MP.",
                    Price = 10990000,
                    StrPrice = "5.190.000 đ",
                    ImagePath = "Images/Realme/realme-9-4g-1-1.jpg"
                }
            };
        }
        public static List<NewsItem> SearchListItem(string title)
        {
            if(!string.IsNullOrEmpty(title))
            {
                var items = GetList().Where(item => item.Title.Contains(title) || item.Description.Contains(title)).ToList();
                TitleToUpper(items);
                return items;
            }
            return new List<NewsItem>();
        }

        private static void TitleToUpper(List<NewsItem> items)
        {
            if(items.Count > 0)
                items.ForEach(item => { item.Title = item.Title.ToUpper(); });
        }
    }
}
