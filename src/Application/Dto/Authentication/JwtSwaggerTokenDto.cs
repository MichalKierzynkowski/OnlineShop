namespace Application.Dto.Authentication;

public class JwtSwaggerTokenDto : JwtTokenDto
{
    public string SwaggerValue { get; set; }
    
    public JwtSwaggerTokenDto(string token)
    {
        Value = token;
        SwaggerValue = "Bearer " + token;
    }
}