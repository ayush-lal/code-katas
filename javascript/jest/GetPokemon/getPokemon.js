const fetch = require("isomorphic-fetch");

const getPokemon = (pokemon) => {
  if (!pokemon) throw new Error("no Pokemon name provided");

  const result = fetch(`https://pokeapi.co/api/v2/pokemon/${pokemon}/`)
    .then((res) => res.json())
    .catch((err) => {
      throw new Error("Pokemon not found");
    });

  return result;
};

module.exports = { getPokemon };
