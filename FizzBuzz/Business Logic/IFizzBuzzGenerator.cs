﻿namespace FizzBuzz.Business_Logic;

public interface IFizzBuzzGenerator
{
	/**
	* Generate results between the given bounds (inclusive)
	*/
	List<string> GenerateResults(int lowerBound, int upperBound);
}