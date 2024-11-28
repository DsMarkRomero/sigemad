# Etapa 1: Construcción de la aplicación Angular
FROM node:18-alpine AS build
WORKDIR /app

# Copiar los archivos necesarios para instalar dependencias
COPY package.json package-lock.json ./
RUN npm install

# Copiar el resto del código fuente al contenedor
COPY ./ ./ 

# Ejecutar el build en modo producción
RUN npm run build

# Etapa 2: Servir la aplicación con Nginx
FROM nginx:1.21.6
WORKDIR /usr/share/nginx/html

# Eliminar el archivo index.html predeterminado de Nginx
RUN rm -f index.html

# Copiar los archivos compilados desde la etapa de construcción
COPY --from=build /app/dist/sigemad/browser/ .

# Copiar configuración personalizada para Nginx (solo el bloque server)
COPY nginx.conf /etc/nginx/conf.d/default.conf

# Exponer el puerto necesario para Kubernetes
EXPOSE 80

# Comando por defecto para iniciar Nginx
CMD ["nginx", "-g", "daemon off;"]
