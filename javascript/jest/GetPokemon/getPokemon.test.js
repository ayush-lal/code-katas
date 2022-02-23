const { getPokemon } = require("./getPokemon.js");

describe("Testing getPokemon() Implementation", () => {
  test("GivenNoPokemon_ThenThrowError", () => {
    expect(getPokemon).toThrow("no Pokemon name provided");
  });

  test("GivenValidPokemon_ThenReturnData", async () => {
    const pokemon = "pikachu";
    const data = await getPokemon(pokemon);

    expect(data.name).toEqual(pokemon);
  });

  test("GivenUnknownPokemon_ThenThrowError", async () => {
    const unknownPokemon = "pikachu-unknown";
    try {
      await getPokemon(unknownPokemon);
    } catch (error) {
      expect(error.message).toBe("Pokemon not found");
    }
  });
});
