namespace HomeWork_19.N19_HT2_params_ref;
/*
AggregationService dan foydalaning unda quyidagi methodlar bo'lsin
- Sum ( params int[] values ) - qiymatlarni summasini qaytarsin
- Average ( params int[] values ) - qiymatlar o'rtachasini qaytarsin
- Min ( params int[] values ) - qiymatlar ichidan eng kichik qiymatni qaytarsin
- Max  ( params int[] values ) - qiymatlar ichidan eng katta qiymatni qaytarsin
- Increment ( ref int value ) - agar qiymat int.MaxValue dan kichik bo'lsa qiymatni bittaga oshirsin
- Decrement ( ref out value ) - agar qiymat int.MinValue dan katta bo'lsa qiymatni bittaga kamaytirsin

- array yarating va Sum, Average, Min, Max methodlari natijalarini ekranga chiqaring
- 4 ta o'zgaruvchi oching ( 6, int.MaxValue, -10, int.MinValue qiymatlari bilan ), Increment va Decrement methodlarini chaqirgandan kn o'zgaruvchi qiymati ekranga chiqsina
 */

public static class AggregationService
{
    public static int Sum(params int[] values)
    {
        int result = 0;
        foreach (var v in values)
        {
            result += v;
        }
        return result;
    }

    public static double Average(params int[] values)
    {
        int sum = 0;
        var length = values.Length;
        
        foreach (var v in values)
        {
            sum += v;
        }
        return sum / length;
    }

    public static int Min(params int[] values)
    {
        var result = values[0];
        foreach (var c in values)
        {
            if (c < result)
                result = c;
        }
        return result;
    }

    public static int Max(params int[] values)
    {
        var result = values[0];
        foreach (var c in values)
        {
            if (c > result)
                result = c;
        }
        
        return result;
    }

    public static void Increment(ref int value)
    {
        if (value < int.MaxValue)
            value += 1;
    }

    public static void Decrement(ref int value)
    {
        if(value > int.MinValue)
            value -= 1;
    }
}