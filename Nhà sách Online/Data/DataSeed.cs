using Microsoft.AspNetCore.Identity;
using Nhà_sách_Online.Const;

namespace Nhà_sách_Online.Data
{
    public class DataSeed
    {
        public static async Task KhoiTaoDuLieuMacDinh(IServiceProvider dichvu)
        {
            var quanLyNguoiDung = dichvu.GetService<UserManager<IdentityUser>>();
            var quanLyVaiTro = dichvu.GetService<RoleManager<IdentityRole>>();

            // Thêm một vai trò vào cơ sở dữ liệu
            await quanLyVaiTro.CreateAsync(new IdentityRole(Roles.Admin.ToString()));
            await quanLyVaiTro.CreateAsync(new IdentityRole(Roles.User.ToString()));

            //Tạo thông tin mặc định cho tài khoản Admin
            // bao gồm Username, Email, xác thực Email
            var quanTri = new IdentityUser
            {
                UserName = "testadmin@gmail.com",
                Email = "testadmin@gmail.com",
                EmailConfirmed = true,
            };

            var nguoiDungTrongCsdl = await quanLyNguoiDung.FindByEmailAsync(quanTri.Email);
            //Nếu tài khoản Admin không tồn tại tỏng Csdl (chưa có trong csdl)
            if (nguoiDungTrongCsdl is null)
            {
                //Tạo tài khoản Admin mới với mật khẩu là 12345
                var ketQua = await quanLyNguoiDung.CreateAsync(quanTri, "Mebeo1402.");
                if (ketQua.Succeeded)
                {
                    await quanLyNguoiDung.AddToRoleAsync(quanTri, Roles.Admin.ToString());
                }
                else
                {
                    foreach (var error in ketQua.Errors)
                    {
                        Console.WriteLine(error.Description);
                    }
                }
            }
        }

    }
}
