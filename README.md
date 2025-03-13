# Sistema para la Administración de Viveros

Este proyecto tiene como objetivo implementar un sistema para la administración de viveros, permitiendo llevar un registro organizado de los **Productores**, sus **Fincas**, **Viveros**, las **Labores agrícolas** realizadas y los **Productos de Control** aplicados (Plagas, Hongos, Fertilizantes).

---

## Modelo del Dominio - ORM

Se desarrollaron las entidades del dominio aplicando **programación orientada a objetos** y **mapeo relacional (ORM)** con anotaciones, permitiendo representar de forma clara las relaciones entre los elementos del sistema.

### Entidades Principales:
- **Productor**
- **Finca**
- **Vivero**
- **Labor**
- **ProductoControl** (abstracta)
  - ProductoControlHongo
  - ProductoControlPlaga
  - ProductoControlFertilizante

### Relaciones:
- Un **Productor** puede tener varias **Fincas**
- Una **Finca** puede tener varios **Viveros**
- Un **Vivero** puede tener varias **Labores**
- Cada **Labor** está relacionada con un **Producto de Control**

---

## Pruebas Unitarias

Se implementaron pruebas unitarias con `xUnit` para validar tanto la creación de entidades como las relaciones entre ellas.

Archivos de prueba disponibles en la carpeta `Test/`:

---

## Tecnologías Utilizadas

- C# (.NET)
- ORM con anotaciones (DataAnnotation - Entity Framework)
- xUnit (Testing Framework)
- Git & GitHub

---


## ¿Cómo ejecutar el proyecto?

1. Clonar el repositorio:
   ```bash
   git clone https://github.com/dslopez0618/Sistema_Vivero.git
2. Abrir la solución SistemaVivero.sln con Visual Community
3. Ejecutar las pruebas con el explorador de pruebas integrado

---

## Autor

Daniel Steven López Mejía
Proyecto académico - Ingeniería de Sistemas y Computación
Universidad Tecnológica de Pereira
