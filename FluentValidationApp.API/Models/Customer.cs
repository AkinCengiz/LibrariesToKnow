﻿namespace FluentValidationApp.API.Models;

public class Customer
{
	public int Id { get; set; }
	public string Name { get; set; }
	public string Email { get; set; }
	public int Age { get; set; }
	public DateTime? BirthDate { get; set; }
	public Gender Gender { get; set; }
}
