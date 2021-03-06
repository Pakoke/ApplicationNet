﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebCommonApplication.Models
{
    public class Car
    {
        public string ID { get; set; }

        [Display(Name = "Año")]
        [Required]
        public int Year { get; set; }

        [Display(Name = "Hecho por:")]
        public string Make { get; set; }

        [Display(Name = "Modelo")]
        [Required]
        public string Model { get; set; }

        public Car()
        {
            
        }
    }

    //CREATE TABLE `VehicleModelYear` (
	//`id` INT UNSIGNED NOT NULL AUTO_INCREMENT,
	//`year` INT(4) UNSIGNED NOT NULL,
	//`make` VARCHAR(50) NULL,
	//`model` VARCHAR(50) NOT NULL,
    //PRIMARY KEY(`id`),
	//UNIQUE `U_VehicleModelYear_year_make_model` (`year`, `make`, `model`),
	//INDEX `I_VehicleModelYear_year` (`year`),
	//INDEX `I_VehicleModelYear_make` (`make`),
	//INDEX `I_VehicleModelYear_model` (`model`)
    //) ENGINE=InnoDB DEFAULT CHARSET=utf8;
}