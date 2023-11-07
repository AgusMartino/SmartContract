module.exports = {
    networks: {
      development: {
        host: "127.0.0.1",  // La dirección IP del nodo de Ganache (localhost).
        port: 7545,        // El puerto en el que se ejecuta Ganache.
        network_id: "*"    // El ID de red, "*" significa cualquier red.
      }
    },
    // Otras configuraciones opcionales aquí.
  };