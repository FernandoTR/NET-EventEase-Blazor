# EventEase

EventEase es una aplicación web desarrollada con **Blazor y .NET 7** que permite la gestión de eventos corporativos y sociales. Este proyecto está diseñado como ejemplo de desarrollo fullstack en .NET, utilizando buenas prácticas de componentes, data binding, validación y manejo de estado.

## Funcionalidades principales

- **Lista de eventos:**  
  Visualiza todos los eventos disponibles con información como nombre, fecha y ubicación.  
  Incluye optimización para grandes volúmenes de datos usando virtualización.

- **Detalle de eventos:**  
  Navega a una página de detalles de cada evento para ver información específica.

- **Registro de usuarios:**  
  Formulario con validación para registrar asistentes, incluyendo nombre, correo y selección de evento.  
  Los datos se validan en tiempo real usando `DataAnnotations`.

- **Manejo de sesión:**  
  Servicio de estado que permite rastrear la sesión del usuario y su registro en eventos.

- **Seguimiento de asistencia:**  
  Muestra la participación del usuario en el evento registrado, de manera dinámica según su sesión.

- **Routing seguro:**  
  Maneja rutas inválidas mostrando mensajes claros y redireccionando a páginas válidas.

## Tecnologías utilizadas

- **.NET 7**
- **Blazor WebAssembly**
- **C#**
- **Bootstrap** para estilos básicos
- **Inyección de dependencias y servicios** para manejo de estado

## Objetivo del proyecto

EventEase sirve como ejemplo de cómo construir una aplicación web moderna con **.NET y Blazor**, incluyendo:

- Componentes reutilizables
- Formularios con validación
- Data binding bidireccional
- Navegación y routing
- Optimización de rendimiento para grandes listas
- Manejo de estado de usuario

## Cómo ejecutar

1. Clona el repositorio:  
   ```bash
   git clone https://github.com/tuusuario/EventEase.git
