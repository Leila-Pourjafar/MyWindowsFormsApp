
namespace Models
{
    public class User : BaseEntity
    {
        public User() : base()
        {

        }
        /*******************/
        [System.ComponentModel.DataAnnotations.Required
            (AllowEmptyStrings = false)]
        [System.ComponentModel.DataAnnotations.StringLength
            (maximumLength: 20)]
        [System.ComponentModel.DataAnnotations.Schema.Index
            (IsUnique = true)]
        public string UserName { get; set; }
        /*******************/

        [System.ComponentModel.DataAnnotations.Required
            (AllowEmptyStrings = false)]
        [System.ComponentModel.DataAnnotations.StringLength
            (maximumLength: 40)]
        public string Password { get; set; }
        /*******************/

        [System.ComponentModel.DataAnnotations.Required
            (AllowEmptyStrings = false)]
        [System.ComponentModel.DataAnnotations.StringLength
            (maximumLength: 100)]
        [System.ComponentModel.DataAnnotations.Schema.Index
            (IsUnique = true)]
        public string EmailAddress { get; set; }

        /*******************/
        [System.ComponentModel.DataAnnotations.StringLength
          (maximumLength: 50)]
        [System.ComponentModel.DataAnnotations.Schema.Index
            (IsUnique = false)]
        public string FullName { get; set; }
        /*******************/
        public bool IsActive { get; set; }

        /*******************/
        public System.DateTime? BrithDate { get; set; }

        /*******************/
        public string Description { get; set; }
    }
}
