# ASP.NET Core Web API for Todo Application

## Description
This is a RESTful API built with ASP.NET Core 6.0 to support the Todo application. The API provides endpoints to manage todo lists, including creating, reading, updating, and deleting todo items. It serves as the backend for a React-based frontend application.

## Features
- Retrieve all todos for a specific user.
- Add a new todo item.
- Update an existing todo item (title or completed status).
- Delete a todo item.

## Endpoints
### Base URL
`https://localhost:7026/api/Tasks`

### Endpoints
- **GET** `/Tasks`
  - Retrieves all todo items for the user.
- **POST** `/Tasks`
  - Adds a new todo item.
  - **Body Example**:
    ```json
    {
      "title": "New Task",
      "completed": false,
    }
    ```
- **PATCH** `/Tasks/{id}`
  - Updates an existing todo item.
  - **Body Example** (partial updates supported):
    ```json
    {
      "title": "Updated Task Title",
      "completed": true
    }
    ```
- **DELETE** `/Tasks/{id}`
  - Deletes a todo item by its ID.
