# 🗼 Torre de Hanoi - Juego Interactivo

Una implementación moderna del clásico juego de la Torre de Hanoi desarrollada en C# con Windows Forms. El juego presenta una interfaz gráfica intuitiva donde los jugadores pueden mover discos entre tres torres siguiendo las reglas tradicionales.

## ✨ Características

- **Interfaz Gráfica Amigable**: Tres torres visualizadas con ListBox para una experiencia de usuario clara 
- **Validación Inteligente**: El juego valida automáticamente los movimientos según las reglas de Hanoi
- **Generación Aleatoria**: Los discos se generan aleatoriamente en una de las tres torres al inicio
- **Detección de Victoria**: Sistema automático que detecta cuando el jugador ha completado el puzzle
- **Reinicio Rápido**: Botón para reiniciar el juego en cualquier momento

## 🚀 Tecnologías Utilizadas

- **C# .NET 6.0**: Framework principal de desarrollo
- **Windows Forms**: Para la interfaz gráfica de usuario
- **Estructuras de Datos Personalizadas**: Implementación propia de Stack usando listas enlazadas

## 🏗️ Arquitectura del Proyecto

El proyecto sigue una arquitectura de tres capas:

```
📁 Hanoi/
├── 📄 Hanoi.cs      # Lógica principal y interfaz de usuario
├── 📄 Stack.cs      # Implementación de la estructura de datos Stack
├── 📄 Nodo.cs       # Clase nodo para la lista enlazada
└── 📄 Program.cs    # Punto de entrada de la aplicación
```

### Componentes Principales

- **`Hanoi.cs`**: Clase principal que maneja la interfaz y la lógica del juego
- **`Stack.cs`**: Implementación personalizada de una pila usando nodos enlazados
- **`Nodo.cs`**: Estructura de datos para los elementos de la pila

## 🎮 Cómo Jugar

1. **Inicio**: El juego comienza con 10 discos colocados aleatoriamente en una de las tres torres
2. **Movimiento**: Haz clic en los botones "Mover" de cada torre para seleccionar elementos
3. **Destino**: Elige la torre de destino mediante el cuadro de diálogo
4. **Reglas**: Solo puedes colocar un disco más pequeño sobre uno más grande
5. **Victoria**: 
