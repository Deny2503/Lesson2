using Lesson2.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Lesson2.Pages
{
    public class GalleryModel : PageModel
    {
        public List<CardModel> Cards { get; set; } = new();

        [BindProperty(SupportsGet = true)]
        public int? SelectedId { get; set; }

        public void OnGet()
        {
            Cards = new List<CardModel>
            {
                new CardModel { Id=1, Title="������", Description="������� �����", FullDescription="������ � ������� � �����������, ��������� ��� ������ ������", ImageUrl="https://pibig.info/uploads/posts/2024-03/1709578476_pibig-info-p-anime-kirito-anime-vkontakte-29.jpg" },
                new CardModel { Id=2, Title="�����", Description="������������ ������", FullDescription="����� � ������� � ����������, ��������� ��� ������������", ImageUrl="https://cdna.artstation.com/p/assets/images/images/010/204/764/large/do-nguyen-03-1-3.jpg?1523157899" },
                new CardModel { Id=3, Title="�����", Description="������� GGO", FullDescription="����� � ��������� � ������� �� ��������, ������ �������", ImageUrl="https://cs14.pikabu.ru/post_img/big/2021/11/27/9/1638022090142149758.jpg" },
                new CardModel { Id=4, Title="����", Description="������ ������", FullDescription="���� � ������ � ��������������, ��� � ALO", ImageUrl="https://pibig.info/uploads/posts/2021-05/1620044357_19-pibig_info-p-lifa-mastera-mecha-anime-krasivo-23.jpg" },
                new CardModel { Id=5, Title="�����", Description="������ Underworld", FullDescription="����� � ������ � ������, ������ �������� Underworld", ImageUrl="https://pibig.info/uploads/posts/2022-11/1669352223_8-pibig-info-p-alisa-sao-vkontakte-8.jpg" },
                new CardModel { Id=6, Title="�����", Description="���� ������", FullDescription="����� � ������, ������, ������� ����� ������� � ������ �����", ImageUrl="https://pibig.info/uploads/posts/2022-11/1668794819_3-pibig-info-p-yudzhio-instagram-3.jpg" },
            };
        }
    }
}
