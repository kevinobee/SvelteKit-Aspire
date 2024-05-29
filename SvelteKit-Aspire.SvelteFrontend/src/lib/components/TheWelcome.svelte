<script lang="ts">
	import { onMount } from 'svelte';

	interface WeatherForecast {
		date: string;
		temperatureC: number;
		temperatureF: number;
		summary: string;
	}

	type Forecasts = WeatherForecast[];

	let name = 'TheWelcome';
	let forecasts: Forecasts = [];
	let loading: boolean = true;
	let error: unknown = null;

	onMount(async () => {
		try {
			const res = await fetch(`/api/weatherforecast`);
			forecasts = await res.json();
		} catch (err) {
			error = err;
		} finally {
			loading = false;
		}
	});
</script>

{#if loading}
	<progress></progress>
{:else if error}
	<div class="error">
		We are unable to fetch the latest weather forecast. Please try again later.
	</div>
{:else}
	<table>
		<thead>
			<tr>
				<th>Date</th>
				<th>Temp. (C)</th>
				<th>Temp. (F)</th>
				<th>Summary</th>
			</tr>
		</thead>
		<tbody>
			{#each forecasts as forecast}
				<tr>
					<td>{forecast.date}</td>
					<td>{forecast.temperatureC}</td>
					<td>{forecast.temperatureF}</td>
					<td>{forecast.summary}</td>
				</tr>
			{/each}
		</tbody>
	</table>
{/if}

<style>
	:root {
		--error: #FF3E00; 
	}

	progress {
		margin-inline: 1rem;
		margin-block: 2rem;
		width: 250px;
		height: 36px;
	}

	.error {
		margin-inline: 1rem;
		margin-block: 2rem;
		color: var(--error);
	}
	table {
		border: none;
		border-collapse: collapse;
	}

	th {
		font-size: x-large;
		font-weight: bold;
		border-bottom: solid 0.2rem hsla(160, 100%, 37%, 1);
	}

	th,
	td {
		padding: 1rem;
	}

	td {
		text-align: center;
		font-size: large;
	}

	tr:nth-child(even) {
		background-color: var(--vt-c-black-soft);
	}
</style>
