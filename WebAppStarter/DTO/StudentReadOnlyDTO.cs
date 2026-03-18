namespace WebAppStarter.DTO
{
    public record StudentReadOnlyDTO(int Id, string? Firstname, string? Lastname)
    {
        public StudentReadOnlyDTO() : this(0, null, null)
        {
        }

    }
    
}
