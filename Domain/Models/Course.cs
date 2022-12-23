namespace Domain.Models;

public class Course
{

    public int Id { get; set; }                //Идентификатор
    public string Title { get; set; }          //Заголовок
    public string Description { get; set; }    //Описание
    public decimal Fee { get; set; }           //Платеж
    public bool HasDiscount { get; set; }      //Есть скидка
    public Course(int id )
    {
        Id = id; 
    }
}
