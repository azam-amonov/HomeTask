// See https://aka.ms/new-console-template for more information

using System.ComponentModel.DataAnnotations;
using HomeWork_19.N19_HT1_in_out;
using HomeWork_19.N19_HT2_params_ref;

Console.WriteLine("Dars 19");
#region 1-Vazifa
/*
Console.WriteLine("Validation!");
// Age validation!
Console.WriteLine($"Age validation: {ValidatorService.IsValidAge(23)}");
Console.WriteLine($"Age validation: {ValidatorService.IsValidAge(123)}");

// Name validation!
Console.WriteLine($"Name validation: {ValidatorService.IsValidName(" Azam      ", out var validNameFormatT)}=> {validNameFormatT}");
Console.WriteLine($"Name validation: {ValidatorService.IsValidName("    A0za-m      ", out var validNameFormatF)}=> {validNameFormatF}");

// Email validation!
Console.WriteLine($"Email validation: {ValidatorService.IsValidEmailAddress("    Azure555@gmail.com", out var validEmailFormatT)}=> {validEmailFormatT}");
Console.WriteLine($"Email validation: {ValidatorService.IsValidEmailAddress("Azure555@gmailcom", out var validEmailFormatF)}=> {validEmailFormatF}");

// Phone Number validation!
Console.WriteLine( $"Phone Number validation: {ValidatorService.IsValidPhoneNumber(
                                "+999(00)000-00-00",
                                out var validPhoneNumberFormatT)}=> {validPhoneNumberFormatT}");
Console.WriteLine( $"Phone Number validation: {ValidatorService.IsValidPhoneNumber(
                                "+999(009uff000-00-00", 
                                out var validPhoneNumberFormatF)}=> {validPhoneNumberFormatF}");

*/
#endregion

#region 2-Vazifa

int[] intArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };
int son = 123423509;
Console.WriteLine($"Sum of array: {AggregationService.Sum(intArray)}");
Console.WriteLine($"Min of array: {AggregationService.Min(intArray)}");
Console.WriteLine($"Max of array: {AggregationService.Max(intArray)}");
Console.WriteLine($"Average of array: {AggregationService.Average(intArray)}");

AggregationService.Increment(ref son);
Console.WriteLine($"Increment of int {son}");

AggregationService.Decrement(ref son);
Console.WriteLine($"Decrement of int {son}");

#endregion