📦 Sample.CleanArchitecture.Microservice

<p align="center">
  <strong>A modern microservice template with Clean Architecture principles</strong>
</p>
<p align="center">
  <img src="https://img.shields.io/badge/license-MIT-blue.svg" alt="License: MIT">
  <img src="https://img.shields.io/badge/dotnet-8.0-blue" alt=".NET 8.0">
  <img src="https://img.shields.io/badge/status-active-green" alt="Project Status: Active">
</p>
<h2 id="introduction">📚 Introduction</h2>
<p>
  <code>Sample.CleanArchitecture.Microservice</code> is a demonstration project that implements a microservice using the principles of Clean Architecture. This project is intended as a template or starting point for building scalable, maintainable, and testable microservices.
</p>
<h2 id="microservices">🧩 Microservices</h2>
<p>
  Microservices is an architectural style that structures an application as a collection of small, autonomous services. Each service is self-contained, independently deployable, and communicates with others via APIs or messaging systems.
</p>
<h3>🔑 Key Characteristics:</h3>
<ul>
  <li><strong>Independence:</strong> Services can be developed, deployed, and scaled independently.</li>
  <li><strong>Decentralization:</strong> Each service manages its own data and operates autonomously.</li>
  <li><strong>Resilience:</strong> Services are designed to handle failures gracefully.</li>
  <li><strong>Scalability:</strong> Services can be scaled independently to meet demand.</li>
</ul>
<h2 id="clean-architecture">🏗️ Clean Architecture</h2>
<p>
  Clean Architecture is a design philosophy that emphasizes separation of concerns, making systems easy to understand, maintain, and test. It organizes code into distinct layers, each with a specific responsibility.
</p>
<h3>📂 Layers in Clean Architecture:</h3>
<ul>
  <li><strong>Entities:</strong> Core business logic and rules, independent of external frameworks.</li>
  <li><strong>Use Cases (Interactors):</strong> Application-specific business rules and actions.</li>
  <li><strong>Interface Adapters:</strong> Bridges between use cases and external systems, converting data formats as needed.</li>
  <li><strong>Frameworks & Drivers:</strong> The outermost layer, containing implementation details like UI frameworks, databases, and web APIs.</li>
</ul>
<h3>🎯 Benefits:</h3>
<ul>
  <li><strong>Testability:</strong> Isolated components are easier to test.</li>
  <li><strong>Maintainability:</strong> Changes in one layer do not affect others.</li>
  <li><strong>Flexibility:</strong> Easier integration of new technologies or modifications.</li>
</ul>
<h2 id="project-structure">🗂️ Project Structure</h2>
<pre>
<code>
Sample.CleanArchitecture.Microservice/
│
├── src(Each Domain Source)/
│   ├── Domain/              # Business logic, entities, and use cases
│   ├── Application/         # Application services, interfaces
│   ├── Infrastructure/      # Implementations for data access, external services
│   └── Web (Gateway)/       # Entry point, controllers, HTTP handling
│
└── README.md                # Project documentation
</code>
</pre>
<h2 id="getting-started">🚀 Getting Started</h2>
<h3 id="prerequisites">📋 Prerequisites</h3>
<ul>
  <li><a href="https://dotnet.microsoft.com/download/dotnet/8.0" target="_blank">.NET 8.0 SDK</a></li>
  <li><a href="https://www.docker.com/" target="_blank">Docker</a> (optional, for containerization)</li>
  <li><a href="https://www.microsoft.com/en-us/sql-server/sql-server-downloads" target="_blank">SQL Server</a> (or any other supported database)</li>
</ul>
<h3 id="running-the-application">🏃‍♂️ Running the Application</h3>
<ol>
  <li>
    <p><strong>Clone the Repository:</strong></p>
    <pre><code>git clone https://github.com/raminsharifiOrg/Sample.CleanArchitechture.Microservice
cd Sample.CleanArchitecture.Microservice</code></pre>
  </li>
  <li>
    <p><strong>Build the Solution:</strong></p>
    <pre><code>dotnet build</code></pre>
  </li>
  <li>
    <p><strong>Run the Application:</strong></p>
    <pre><code>dotnet run --project src/Api</code></pre>
  </li>
  <li>
    <p><strong>Access the API:</strong></p>
    <p>The API will be available at <code>https://localhost:5001</code> by default.</p>
  </li>
</ol>
<h3 id="running-with-docker">🐳 Running with Docker</h3>
<ol>
  <li>
    <p><strong>Build the Docker Image:</strong></p>
    <pre><code>docker build -t sample-cleanarchitecture-microservice .</code></pre>
  </li>
  <li>
    <p><strong>Run the Docker Container:</strong></p>
    <pre><code>docker run -p 5001:80 sample-cleanarchitecture-microservice</code></pre>
  </li>
  <li>
    <p><strong>Access the API:</strong></p>
    <p>The API will be available at <code>http://localhost:5001</code>.</p>
  </li>
</ol>
<h2 id="license">📄 License</h2>
<p>
  This project is licensed under the MIT License - see the <a href="LICENSE">LICENSE</a> file for details.
</p>
<h2 id="acknowledgments">🙏 Acknowledgments</h2>
<p>
  A big thank you to the contributors of the Clean Architecture and Microservices communities for their guidance and inspiration.
</p>
