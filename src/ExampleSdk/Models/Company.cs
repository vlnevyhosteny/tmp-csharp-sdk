
/**
 * Sample Business API
 *
 * The version of the OpenAPI document: 1.0.0
 * Contact: acme@example.com
 *
 * NOTE: This file is auto generated.
 * Do not edit the file manually.
 */
using System.Text.Json.Serialization;
using System.Text.Json;
using ExampleSdk.Core;
namespace ExampleSdk.Models;
public class Company
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }
    [JsonPropertyName("leader")]
    public ILeader? Leader { get; set; }
    [JsonPropertyName("personeel")]
    public CompanyPersoneel? Personeel { get; set; }

    public interface ILeader
    { }
    public class EmployeeLeader : Employee, ILeader
    {

    }
    public class ContractorLeader : Contractor, ILeader
    {

    }
    public interface IPersoneel
    { }
    public class EmployeePersoneel : Employee, IPersoneel
    {

    }
    public class ContractorPersoneel : Contractor, IPersoneel
    {

    }
    public class CompanyPersoneelItem
    {
        [JsonPropertyName("Employee")]
        public Employee? Employee { get; set; }
        [JsonPropertyName("Contractor")]
        public Contractor? Contractor { get; set; }

    }
    public class CompanyPersoneel : System.Collections.Generic.List<CompanyPersoneelItem>
    { }
}
