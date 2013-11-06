SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='TRADITIONAL,ALLOW_INVALID_DATES';

CREATE SCHEMA IF NOT EXISTS `finanzas` DEFAULT CHARACTER SET utf8 COLLATE utf8_general_ci ;
USE `finanzas` ;

-- -----------------------------------------------------
-- Table `finanzas`.`tbt_bancos`
-- -----------------------------------------------------
CREATE  TABLE IF NOT EXISTS `finanzas`.`tbt_bancos` (
  `idtbt_bancos` INT NOT NULL AUTO_INCREMENT ,
  `nomb_banco` VARCHAR(100) NULL ,
  PRIMARY KEY (`idtbt_bancos`) )
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `finanzas`.`tbt_cuentas_bancarias`
-- -----------------------------------------------------
CREATE  TABLE IF NOT EXISTS `finanzas`.`tbt_cuentas_bancarias` (
  `id_cuentas_banc` INT NOT NULL AUTO_INCREMENT ,
  `no_cuenta` VARCHAR(100) NULL ,
  `saldo_actual` VARCHAR(100) NULL ,
  `saldo_anterior` VARCHAR(100) NULL ,
  `idtbt_bancos` INT NOT NULL ,
  PRIMARY KEY (`id_cuentas_banc`) ,
  INDEX `fk_table1_tbt_bancos1_idx` (`idtbt_bancos` ASC) ,
  CONSTRAINT `fk_table1_tbt_bancos1`
    FOREIGN KEY (`idtbt_bancos` )
    REFERENCES `finanzas`.`tbt_bancos` (`idtbt_bancos` )
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `finanzas`.`tbt_nomenclatura`
-- -----------------------------------------------------
CREATE  TABLE IF NOT EXISTS `finanzas`.`tbt_nomenclatura` (
  `id_cts` INT NOT NULL AUTO_INCREMENT ,
  `nombre_cta` VARCHAR(300) NULL ,
  `total_cta` VARCHAR(300) NULL ,
  `saldo_actual` VARCHAR(300) NULL ,
  `saldo_anterior` VARCHAR(300) NULL ,
  `cargo` VARCHAR(300) NULL ,
  `tipo_cta` VARCHAR(300) NULL ,
  `tipo_reporte` VARCHAR(300) NULL ,
  `tipo_saldo` VARCHAR(300) NULL ,
  `id_cuentas_banc` INT NOT NULL ,
  PRIMARY KEY (`id_cts`) ,
  INDEX `fk_tbt_nomenclatura_tbt_cuentas_bancarias1_idx` (`id_cuentas_banc` ASC) ,
  CONSTRAINT `fk_tbt_nomenclatura_tbt_cuentas_bancarias1`
    FOREIGN KEY (`id_cuentas_banc` )
    REFERENCES `finanzas`.`tbt_cuentas_bancarias` (`id_cuentas_banc` )
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `finanzas`.`Poliza_departamentos`
-- -----------------------------------------------------
CREATE  TABLE IF NOT EXISTS `finanzas`.`Poliza_departamentos` (
  `id_poliza` INT NOT NULL AUTO_INCREMENT ,
  `nombre_dpt` VARCHAR(300) NULL ,
  PRIMARY KEY (`id_poliza`) )
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `finanzas`.`tbt_encabezado`
-- -----------------------------------------------------
CREATE  TABLE IF NOT EXISTS `finanzas`.`tbt_encabezado` (
  `id_encabezado` INT NOT NULL AUTO_INCREMENT ,
  `fecha` DATETIME NULL ,
  `concepto` VARCHAR(45) NULL ,
  `id_poliza` INT NOT NULL ,
  PRIMARY KEY (`id_encabezado`) ,
  INDEX `fk_tbt_encabezado_Poliza_departamentos1_idx` (`id_poliza` ASC) ,
  CONSTRAINT `fk_tbt_encabezado_Poliza_departamentos1`
    FOREIGN KEY (`id_poliza` )
    REFERENCES `finanzas`.`Poliza_departamentos` (`id_poliza` )
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `finanzas`.`tbt_libro_diario`
-- -----------------------------------------------------
CREATE  TABLE IF NOT EXISTS `finanzas`.`tbt_libro_diario` (
  `id_libro_diario` INT NOT NULL AUTO_INCREMENT ,
  `numero de partida` VARCHAR(300) NULL ,
  `id_encabezado` INT NOT NULL ,
  PRIMARY KEY (`id_libro_diario`) ,
  INDEX `fk_tbt_libro_diario_tbt_encabezado1_idx` (`id_encabezado` ASC) ,
  CONSTRAINT `fk_tbt_libro_diario_tbt_encabezado1`
    FOREIGN KEY (`id_encabezado` )
    REFERENCES `finanzas`.`tbt_encabezado` (`id_encabezado` )
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `finanzas`.`tbt_detalle`
-- -----------------------------------------------------
CREATE  TABLE IF NOT EXISTS `finanzas`.`tbt_detalle` (
  `id_detalle` INT NOT NULL AUTO_INCREMENT ,
  `total` VARCHAR(100) NULL ,
  `id_cts` INT NOT NULL ,
  `id_poliza` INT NOT NULL ,
  `id_libro_diario` INT NOT NULL ,
  PRIMARY KEY (`id_detalle`) ,
  INDEX `fk_tbt_detalle_tbt_nomenclatura1_idx` (`id_cts` ASC) ,
  INDEX `fk_tbt_detalle_Poliza_departamentos1_idx` (`id_poliza` ASC) ,
  INDEX `fk_tbt_detalle_tbt_libro_diario1_idx` (`id_libro_diario` ASC) ,
  CONSTRAINT `fk_tbt_detalle_tbt_nomenclatura1`
    FOREIGN KEY (`id_cts` )
    REFERENCES `finanzas`.`tbt_nomenclatura` (`id_cts` )
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_tbt_detalle_Poliza_departamentos1`
    FOREIGN KEY (`id_poliza` )
    REFERENCES `finanzas`.`Poliza_departamentos` (`id_poliza` )
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_tbt_detalle_tbt_libro_diario1`
    FOREIGN KEY (`id_libro_diario` )
    REFERENCES `finanzas`.`tbt_libro_diario` (`id_libro_diario` )
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `finanzas`.`tbt_historial_cuentas`
-- -----------------------------------------------------
CREATE  TABLE IF NOT EXISTS `finanzas`.`tbt_historial_cuentas` (
  `idtbt_historial_cuentas` INT NOT NULL AUTO_INCREMENT ,
  `fecha_inicio` DATETIME NULL ,
  `fecha_final` DATETIME NULL ,
  `id_cts` INT NOT NULL ,
  PRIMARY KEY (`idtbt_historial_cuentas`) ,
  INDEX `fk_tbt_historial_cuentas_tbt_nomenclatura1_idx` (`id_cts` ASC) ,
  CONSTRAINT `fk_tbt_historial_cuentas_tbt_nomenclatura1`
    FOREIGN KEY (`id_cts` )
    REFERENCES `finanzas`.`tbt_nomenclatura` (`id_cts` )
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `finanzas`.`bitacora`
-- -----------------------------------------------------
CREATE  TABLE IF NOT EXISTS `finanzas`.`bitacora` (
  `idbitacora` INT NOT NULL AUTO_INCREMENT ,
  `usu_bit` VARCHAR(45) NULL ,
  `ip_local` VARCHAR(45) NULL ,
  `ip_publica` VARCHAR(45) NULL ,
  `fecha` VARCHAR(45) NULL ,
  `descr` VARCHAR(500) NULL ,
  PRIMARY KEY (`idbitacora`) )
ENGINE = InnoDB;

USE `finanzas` ;


SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;
