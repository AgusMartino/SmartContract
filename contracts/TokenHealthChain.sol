// SPDX-License-Identifier: MIT
pragma solidity >=0.4.0 <0.9.0;

import "@openzeppelin/contracts/token/ERC20/ERC20.sol";

contract HealthChain is ERC20 {
    constructor() ERC20("HealthChain", "HLC") {
        uint256 initialSupply = 100_000_000 * 10 ** 18; // 100,000,000 tokens con 18 decimales
        _mint(msg.sender, initialSupply);
    }

    // Función para que el propietario transfiera 10,000 tokens a una dirección específica
    function transferToAddress(address recipient) public {
        uint256 amount = 50_000 * 10 ** 18; // 50,000 tokens con 18 decimales
        _transfer(msg.sender, recipient, amount);
    }
}