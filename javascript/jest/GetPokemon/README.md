
## Mocking network responses with nock: getPokemon

The `getPokemon` function uses the `isomorphic-fetch` library to get data from [PokeAPI](https://pokeapi.co/). It returns a JSON object.

Your task is to write tests for `getPokemon`, and mock network responses. You'll need to create your own test cases.

Things to consider:

- What sort of data does PokeAPI return? Use the 'Try it now' section on the website to inform your mocked data.
- Async functions don't throw errors in the same way as normal functions. `getPokemon()` and `getPokemon('cartman')` will behave differently.
