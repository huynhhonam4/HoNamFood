using System.Linq;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
namespace BooksStore.Models
{
    public static class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            BooksStoreDbContext context = app.ApplicationServices.CreateScope().ServiceProvider.GetRequiredService<BooksStoreDbContext>();
            if (context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }
            if (!context.Books.Any())
            {
                context.Books.AddRange(
                new Book
                {
                    Title = "Thơm",
                    Description = "Thơm chứa nhiều khoáng chất có thể giúp ngăn ngừa ung thư, giảm viêm khớp, ngăn ngừa các bệnh về mắt do lão hóa",
                    Genre = "Trái cây",
                    Price = 150.000m
                },
                new Book
                {
                    Title = "Chuối",
                    Description = "Chuối không những có hương vị thơm ngon đặc trưng mà tác dụng của chuối với sức khỏe cũng rất lớn.",
                    Genre = "Trái cây",
                    Price = 150.000m
                },
                new Book
                {
                    Title = "Cam",
                    Description = "Cam là loại quả giàu chất chống oxy hóa và chất phytochemical.",
                    Genre = "Trái cây",
                    Price = 250.000m
                },
                new Book
                {
                    Title = "Thịt Lợn",
                    Description = "Hầu hết các mẹ nội trợ đều không có nhiều ý tưởng về các món từ thịt heo, đa số chỉ là làm các món luộc, kho, chiên. Khiến cho thịt heo trở thành món ngán ngấm trong thực đơn bữa cơm gia đình hàng ngày.",
                    Genre = "Thịt",
                    Price = 200.000m
                },
                new Book
                {
                    Title = "Thịt bò",
                    Description = "Thịt bò là một nguồn cung cấp protein, sắt, kẽm vitamin và khoáng chất dồi dào trong chế độ ăn.",
                    Genre = "Thịt",
                    Price = 300.000m
                },
                new Book
                {
                    Title = "Thịt cừu",
                    Description = "Thịt cừu là món ngon bổ dưỡng, giàu vitamin, khoáng chất, cung cấp protein chất lượng cao cho cơ thể. ",
                    Genre = "Thịt",
                    Price = 500.000m
                },
                new Book
                {
                    Title = "Cải xanh",
                    Description = "Rau cải xanh là loại rau thông dụng trong bữa cơm hằng ngày của người Việt.",
                    Genre = "Rau",
                    Price = 90.000m
                },
                new Book
                {
                    Title = "Rau dền",
                    Description = "Rau dền là một loại thực vật. Hạt, dầu và lá được dùng làm thực phẩm. Toàn bộ bộ phận của rau dền được sử dụng để làm thuốc. Rau dền được sử dụng để chữa loét, tiêu chảy, sưng miệng hoặc cổ họng và cholesterol cao",
                    Genre = "Rau",
                    Price = 350.00m
                }
            );
                context.SaveChanges();
            }
        }
    }
}






